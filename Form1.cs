using MarkdownSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MDtoHTMLConverter
{
    public partial class formMDtoHTML : Form
    {
        string fileName, filePath = string.Empty;
        bool isInitState, isErrorText = true;
        TextBox textBox;

        /// <summary>
        /// 메시지 박스 제목 표시 유형
        /// </summary>
        enum ProgramSatatus 
        {
            INIT,
            FILE_READ,
            FILE_SAVE,
            FINISH
        }

        public formMDtoHTML()
        {
            InitializeComponent();
            InitProgram();
            LayoutFooter();
        }

        #region Method
        /// <summary>
        /// 프로그램 초기화
        /// 1. 미리보기 panel 기본 스타일 지정
        /// 2. 파일 경로 empty
        /// </summary>
        private void InitProgram()
        {
            // 상태 초기화
            this.isInitState = true;
            this.isErrorText = false;

            // panel
            this.pnlPreview.Controls.Clear();
            this.pnlPreview.BackColor = Color.WhiteSmoke;

            // 미리보기 default style
            Label lblPreview = new Label();
            lblPreview.Text = "마크다운 파일을 \n선택 또는 드래그하여\n업로드 해주세요.";
            lblPreview.Width = 150;
            lblPreview.Height = 70;
            lblPreview.AutoSize = true;
            lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPreview.Font = new Font("맑은 고딕", 11, FontStyle.Bold);
            lblPreview.ForeColor = Color.Gray;

            this.pnlPreview.Controls.Add(lblPreview);

            // 안내문구 레이아웃 정렬
            int labelX = (this.pnlPreview.Width - lblPreview.Width) / 2;
            int labelY = (this.pnlPreview.Height - lblPreview.Height) / 2;
            lblPreview.Location = new Point(labelX, labelY);

            // 파일경로 리셋
            this.filePath = string.Empty;
            this.fileName = string.Empty;
        }

        /// <summary>
        /// 메시지 박스 제목 표시 메시지
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        private string GetMessageBoxTitle(ProgramSatatus status)
        {
            switch (status)
            {
                case ProgramSatatus.INIT:
                    return "프로그램";
                case ProgramSatatus.FILE_READ:
                    return "파일선택";
                case ProgramSatatus.FILE_SAVE:
                    return "파일변환";
                case ProgramSatatus.FINISH:
                    return "파일저장";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// 마크다운 파일 내용 가져오기
        /// 정상/오류 : 파일/오류 내용
        /// 파일 변환 오류 제어 메시지를 위한 플래그 지정
        /// </summary>
        /// <returns></returns>
        private string ReadMarkdownContent()
        {
            string result = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                isErrorText = true;
                result = ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 마크다운 파일 내용 확인 및 작성 모드 스타일 변경
        /// </summary>
        /// <param name="isReadOnly"></param>
        private void CreateTextMode(bool isReadOnly)
        {
            textBox = new TextBox();
            textBox.Multiline = true; // 여러 줄의 텍스트 허용
            textBox.ScrollBars = ScrollBars.Vertical; // 수직 스크롤바 사용
            textBox.Dock = DockStyle.Fill; // 부모 컨테이너 크기에 맞게 조정
            textBox.ReadOnly = isReadOnly;
            textBox.BackColor = Color.Black;
            textBox.Text = isReadOnly ? ReadMarkdownContent() : string.Empty;
            textBox.Font = new Font("Arial", 12, FontStyle.Bold); // Arial 글꼴, 크기 12, Bold 스타일
            textBox.ForeColor = Color.White;
            textBox.Padding = new System.Windows.Forms.Padding(10);

            this.pnlPreview.Controls.Clear();
            this.pnlPreview.Controls.Add(textBox);
            this.pnlPreview.BackColor = Color.Black;
        }

        /// <summary>
        /// 웹 브라우저 및 메일 기본앱 실행 
        /// </summary>
        /// <param name="url"></param>
        private void OpenBrowser(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        /// <summary>
        /// 푸터 배치
        /// </summary>
        private void LayoutFooter()
        {
            Label lblHyangforest = new Label();
            lblHyangforest.Text = "made by hyangforest.";
            lblHyangforest.Width = 120;
            lblHyangforest.Height = 20;
            lblHyangforest.AutoSize = true;
            lblHyangforest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblHyangforest.Font = new Font("Consolas", 8, FontStyle.Regular);
            lblHyangforest.ForeColor = Color.FromArgb(255, 130, 130, 130);

            int labelX = (this.pnlFooter.Width - lblHyangforest.Width) / 2;
            int labelY = (this.pnlFooter.Height - lblHyangforest.Height) / 2;
            lblHyangforest.Location = new Point(labelX, labelY);

            this.pnlFooter.Controls.Add(lblHyangforest);
        }

        /// <summary>
        /// 확인 - 메시지박스
        /// </summary>
        /// <param name="title">메시지 상자 제목</param>
        /// <param name="message">메시지 내용</param>
        /// <returns></returns>
        private DialogResult ConfirmMessageBox(string title, string message) 
        {
            DialogResult result = MessageBox.Show(title, message, MessageBoxButtons.OKCancel);
            return result;
        }

        /// <summary>
        /// 알림 - 메시지박스
        /// </summary>
        /// <param name="title">메시지 상자 제목</param>
        /// <param name="message">메시지 내용</param>
        private void AlertMessageBox(string title, string message)
        {
            MessageBox.Show(message, title);
        }
        #endregion

        #region Event
        /// <summary>
        /// 푸터 위쪽 테두리 그리기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            int lineWidth = pnlFooter.Width; // 패널 너비만큼
            Color customColor = Color.FromArgb(255, 220, 220, 220);

            Pen linePen = new Pen(customColor, 1); // 색상과 선 두께 설정

            e.Graphics.DrawLine(linePen, 0, 0, lineWidth, 0);
        }
        /// <summary>
        /// Markdown 파일 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btmMd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\"; // 초기 디렉토리 설정
            openFileDialog.Filter = "마크다운 파일(*.md)|*.md|모든 파일 (*.*)|*.*"; // 파일 필터 설정
            openFileDialog.Multiselect = false; // 단일 파일 선택
            openFileDialog.Title = "마크다운(*.md) 파일 가져오기";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                isInitState = false;

                // file 읽어오기
                filePath = openFileDialog.FileName;

                // 확장자를 제외한 파일명 가져오기
                fileName = Path.GetFileNameWithoutExtension(filePath);

                // 텍스트 컨트롤 생성(파일 내용 가져오기 및 작성하기)
                CreateTextMode(true);
            }
        }

        /// <summary>
        /// 내용 작성하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrtie_Click(object sender, EventArgs e)
        {
            isInitState = false;
            filePath = string.Empty;
            fileName = string.Format("newMarkdown_{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            CreateTextMode(false);
        }

        /// <summary>
        /// 메뉴 스크립트 - 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = this.ConfirmMessageBox("초기 상태로 되돌리시겠습니까?", GetMessageBoxTitle(ProgramSatatus.INIT));

            if (result == DialogResult.OK)
            {
                this.InitProgram();
            }
        }

        /// <summary>
        /// 메뉴 : Tistory
        /// 프로그램 개발 스토리 링크 열기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenBrowser("https://hyangforest.tistory.com/");
        }

        /// <summary>
        /// 메뉴 : 문의
        /// 프로그램 오류 및 의견 이메일 발송
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenBrowser("mailto:hyangforest@gami.com?subject=프로그램 문의");
        }

        private void pnlPreview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Markdown 파일 드래그 앤 다운 이벤트 시 내용 읽어오기 및 텍스트 박스 설정하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPreview_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 1)
            {
                // 파일 가져오기
                filePath = files[0];

                if (Path.GetExtension(filePath) == ".md")
                {
                    // 확장자를 제외한 파일명 가져오기
                    fileName = Path.GetFileNameWithoutExtension(filePath);

                    // 텍스트 컨트롤 생성(파일 내용 가져오기 및 작성하기)
                    CreateTextMode(true);
                }
                else
                {
                    this.AlertMessageBox("확장자 .md만 가져올 수 있습니다.", GetMessageBoxTitle(ProgramSatatus.FILE_READ));
                }
            }
            else
            {
                this.AlertMessageBox("하나의 파일만 가져올 수 있습니다.", GetMessageBoxTitle(ProgramSatatus.FILE_READ));
            }


        }

        /// <summary>
        /// HTML 파일 변환하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHTML_Click(object sender, EventArgs e)
        {
            if (isInitState)
            {
                this.AlertMessageBox("변환할 내용이 없습니다.", GetMessageBoxTitle(ProgramSatatus.FILE_SAVE));

                return;
            }

            if (isErrorText)
            {
                this.AlertMessageBox("파일 변환이 실패하였습니다.", GetMessageBoxTitle(ProgramSatatus.FILE_SAVE));
                return;
            }


            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "저장 폴더 선택";
            folderBrowserDialog.SelectedPath = @"C:\";

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // 사용자가 선택한 디렉토리의 경로
                string selectedFolder = folderBrowserDialog.SelectedPath;

                // Markdown을 HTML로 변환
                Markdown markdown = new Markdown();
                string html = markdown.Transform(textBox.Text);

                // HTML 파일로 저장
                string htmlFilePath = string.Format("{0}/{1}.html", selectedFolder, fileName);

                bool isConvert = true;

                if (File.Exists(htmlFilePath))
                {
                    DialogResult fileUpdate = this.ConfirmMessageBox("이미 동일한 파일명이 존재합니다. 파일을 파일을 변환하시겠습니까?", GetMessageBoxTitle(ProgramSatatus.FILE_SAVE));

                    if (fileUpdate == DialogResult.Cancel)
                    {
                        isConvert = false;
                    }
                }

                if (isConvert)
                {
                    File.WriteAllText(htmlFilePath, html);

                    DialogResult openBroswer = this.ConfirmMessageBox("변환이 완료되었습니다. 웹 페이지를 실행하시겠습니까?", GetMessageBoxTitle(ProgramSatatus.FINISH));

                    if (openBroswer == DialogResult.OK)
                    {
                        this.OpenBrowser(htmlFilePath);
                    }
                    else
                    {
                        this.AlertMessageBox("변환이 완료되었습니다.", GetMessageBoxTitle(ProgramSatatus.FINISH));
                    }
                }
                else
                {
                    this.AlertMessageBox("파일명 수정 후 다시 시도해주십시오.", GetMessageBoxTitle(ProgramSatatus.FILE_SAVE));
                }
            }
        }
        #endregion
    }
}
