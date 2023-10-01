namespace MDtoHTMLConverter
{
    partial class formMDtoHTML
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMDtoHTML));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMarkdown = new System.Windows.Forms.Panel();
            this.btmMd = new System.Windows.Forms.Button();
            this.btnWrtie = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.btnHTML = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMarkdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(434, 28);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initToolStripMenuItem,
            this.tistoryToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.programToolStripMenuItem.Text = "프로그램";
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.initToolStripMenuItem.Text = "초기화";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // tistoryToolStripMenuItem
            // 
            this.tistoryToolStripMenuItem.Name = "tistoryToolStripMenuItem";
            this.tistoryToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.tistoryToolStripMenuItem.Text = "Tistory";
            this.tistoryToolStripMenuItem.Click += new System.EventHandler(this.tistoryToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.infoToolStripMenuItem.Text = "문의";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlMarkdown, 0, 0);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 3);
            this.pnlMain.Controls.Add(this.pnlPreview, 0, 1);
            this.pnlMain.Controls.Add(this.btnHTML, 0, 2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 4;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.pnlMain.Size = new System.Drawing.Size(434, 973);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlMarkdown
            // 
            this.pnlMarkdown.Controls.Add(this.btmMd);
            this.pnlMarkdown.Controls.Add(this.btnWrtie);
            this.pnlMarkdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMarkdown.Location = new System.Drawing.Point(30, 15);
            this.pnlMarkdown.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.pnlMarkdown.Name = "pnlMarkdown";
            this.pnlMarkdown.Size = new System.Drawing.Size(374, 47);
            this.pnlMarkdown.TabIndex = 4;
            // 
            // btmMd
            // 
            this.btmMd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btmMd.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btmMd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btmMd.Image = ((System.Drawing.Image)(resources.GetObject("btmMd.Image")));
            this.btmMd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmMd.Location = new System.Drawing.Point(0, 0);
            this.btmMd.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.btmMd.Name = "btmMd";
            this.btmMd.Padding = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.btmMd.Size = new System.Drawing.Size(185, 47);
            this.btmMd.TabIndex = 3;
            this.btmMd.Text = "MD 파일선택";
            this.btmMd.UseVisualStyleBackColor = true;
            this.btmMd.Click += new System.EventHandler(this.btmMd_Click);
            // 
            // btnWrtie
            // 
            this.btnWrtie.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWrtie.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWrtie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnWrtie.Image = ((System.Drawing.Image)(resources.GetObject("btnWrtie.Image")));
            this.btnWrtie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWrtie.Location = new System.Drawing.Point(189, 0);
            this.btnWrtie.Name = "btnWrtie";
            this.btnWrtie.Padding = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.btnWrtie.Size = new System.Drawing.Size(185, 47);
            this.btnWrtie.TabIndex = 0;
            this.btnWrtie.Text = "내용 작성하기";
            this.btnWrtie.UseVisualStyleBackColor = true;
            this.btnWrtie.Click += new System.EventHandler(this.btnWrtie_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlFooter.Location = new System.Drawing.Point(15, 914);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(404, 57);
            this.pnlFooter.TabIndex = 0;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // pnlPreview
            // 
            this.pnlPreview.AllowDrop = true;
            this.pnlPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Location = new System.Drawing.Point(30, 77);
            this.pnlPreview.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(374, 758);
            this.pnlPreview.TabIndex = 0;
            this.pnlPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPreview_DragDrop);
            this.pnlPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPreview_DragEnter);
            // 
            // btnHTML
            // 
            this.btnHTML.BackColor = System.Drawing.Color.Transparent;
            this.btnHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHTML.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHTML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnHTML.Image = ((System.Drawing.Image)(resources.GetObject("btnHTML.Image")));
            this.btnHTML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHTML.Location = new System.Drawing.Point(100, 850);
            this.btnHTML.Margin = new System.Windows.Forms.Padding(100, 15, 95, 15);
            this.btnHTML.Name = "btnHTML";
            this.btnHTML.Padding = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.btnHTML.Size = new System.Drawing.Size(239, 47);
            this.btnHTML.TabIndex = 3;
            this.btnHTML.Text = "HTML 파일로 변환하기";
            this.btnHTML.UseVisualStyleBackColor = false;
            this.btnHTML.Click += new System.EventHandler(this.btnHTML_Click);
            // 
            // formMDtoHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 1001);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMDtoHTML";
            this.Text = "마크다운 HTML 파일 생성하기";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMarkdown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btmMd;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Button btnHTML;
        private System.Windows.Forms.Button btnWrtie;
        private System.Windows.Forms.Panel pnlMarkdown;
    }
}

