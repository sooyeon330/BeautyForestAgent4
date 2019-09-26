namespace BeautyForestAgent
{
    partial class FormMemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Status = new System.Windows.Forms.StatusStrip();
            this.tabMode = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.loadFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.btnLoadFileSelect = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSaveFileSelect = new System.Windows.Forms.Button();
            this.txtSaveText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Status.SuspendLayout();
            this.tabMode.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(0, 319);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(384, 22);
            this.Status.SizingGrip = false;
            this.Status.TabIndex = 0;
            this.Status.Text = "3616채수연";
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.tab1);
            this.tabMode.Controls.Add(this.tab2);
            this.tabMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMode.Location = new System.Drawing.Point(0, 0);
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(384, 319);
            this.tabMode.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.textBox4);
            this.tab1.Controls.Add(this.btnLoadFile);
            this.tab1.Controls.Add(this.btnLoadFileSelect);
            this.tab1.Controls.Add(this.txtLoadFile);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(376, 293);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "파일읽기";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.txtSaveText);
            this.tab2.Controls.Add(this.btnSaveFileSelect);
            this.tab2.Controls.Add(this.btnSaveFile);
            this.tab2.Controls.Add(this.txtSaveFile);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(376, 293);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "파일쓰기";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.FileName = "openFileDialog1";
            this.loadFileDlg.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "3616채수연";
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(7, 4);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(200, 21);
            this.txtLoadFile.TabIndex = 0;
            // 
            // btnLoadFileSelect
            // 
            this.btnLoadFileSelect.Location = new System.Drawing.Point(214, 4);
            this.btnLoadFileSelect.Name = "btnLoadFileSelect";
            this.btnLoadFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFileSelect.TabIndex = 1;
            this.btnLoadFileSelect.Text = "파일 선택";
            this.btnLoadFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(296, 4);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(7, 7);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(199, 21);
            this.txtSaveFile.TabIndex = 0;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(293, 7);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFileSelect
            // 
            this.btnSaveFileSelect.Location = new System.Drawing.Point(212, 7);
            this.btnSaveFileSelect.Name = "btnSaveFileSelect";
            this.btnSaveFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFileSelect.TabIndex = 2;
            this.btnSaveFileSelect.Text = "파일 선택";
            this.btnSaveFileSelect.UseVisualStyleBackColor = true;
            // 
            // txtSaveText
            // 
            this.txtSaveText.Location = new System.Drawing.Point(9, 35);
            this.txtSaveText.Multiline = true;
            this.txtSaveText.Name = "txtSaveText";
            this.txtSaveText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSaveText.Size = new System.Drawing.Size(359, 252);
            this.txtSaveText.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 32);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(364, 255);
            this.textBox4.TabIndex = 3;
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.tabMode);
            this.Controls.Add(this.Status);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMemo";
            this.Text = "3616채수연";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.tabMode.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnLoadFileSelect;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TextBox txtSaveText;
        private System.Windows.Forms.Button btnSaveFileSelect;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.OpenFileDialog loadFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
    }
}