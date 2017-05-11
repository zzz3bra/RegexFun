namespace RegexFun
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.URLAnalyzeButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileAnalyzeBtn = new System.Windows.Forms.Button();
            this.regexGroupBox = new System.Windows.Forms.GroupBox();
            this.userRegexTextBox = new System.Windows.Forms.TextBox();
            this.yourRegexLbl = new System.Windows.Forms.Label();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultMemo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.regexGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "http://bru.by";
            // 
            // URLAnalyzeButton
            // 
            this.URLAnalyzeButton.Location = new System.Drawing.Point(57, 94);
            this.URLAnalyzeButton.Name = "URLAnalyzeButton";
            this.URLAnalyzeButton.Size = new System.Drawing.Size(105, 23);
            this.URLAnalyzeButton.TabIndex = 1;
            this.URLAnalyzeButton.Text = "Анализ URL";
            this.URLAnalyzeButton.UseVisualStyleBackColor = true;
            this.URLAnalyzeButton.Click += new System.EventHandler(this.URLAnalyzeButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(175, 68);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.URLAnalyzeButton);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сетевые действия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Глубина рекурсивного поиска:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL сайта для анализа:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileAnalyzeBtn);
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Локальные действия:";
            // 
            // FileAnalyzeBtn
            // 
            this.FileAnalyzeBtn.Location = new System.Drawing.Point(39, 94);
            this.FileAnalyzeBtn.Name = "FileAnalyzeBtn";
            this.FileAnalyzeBtn.Size = new System.Drawing.Size(112, 23);
            this.FileAnalyzeBtn.TabIndex = 0;
            this.FileAnalyzeBtn.Text = "Анализ файла";
            this.FileAnalyzeBtn.UseVisualStyleBackColor = true;
            this.FileAnalyzeBtn.Click += new System.EventHandler(this.FileAnalyzeBtn_Click);
            // 
            // regexGroupBox
            // 
            this.regexGroupBox.Controls.Add(this.userRegexTextBox);
            this.regexGroupBox.Controls.Add(this.yourRegexLbl);
            this.regexGroupBox.Location = new System.Drawing.Point(13, 143);
            this.regexGroupBox.Name = "regexGroupBox";
            this.regexGroupBox.Size = new System.Drawing.Size(428, 61);
            this.regexGroupBox.TabIndex = 5;
            this.regexGroupBox.TabStop = false;
            this.regexGroupBox.Text = "Выражение";
            // 
            // userRegexTextBox
            // 
            this.userRegexTextBox.Location = new System.Drawing.Point(17, 34);
            this.userRegexTextBox.Name = "userRegexTextBox";
            this.userRegexTextBox.Size = new System.Drawing.Size(389, 20);
            this.userRegexTextBox.TabIndex = 1;
            this.userRegexTextBox.Text = "^((http[s]?|ftp):\\/)?\\/?([^:\\/\\s]+)((\\/\\w+)*\\/)?$";
            // 
            // yourRegexLbl
            // 
            this.yourRegexLbl.AutoSize = true;
            this.yourRegexLbl.Location = new System.Drawing.Point(38, 18);
            this.yourRegexLbl.Name = "yourRegexLbl";
            this.yourRegexLbl.Size = new System.Drawing.Size(346, 13);
            this.yourRegexLbl.TabIndex = 0;
            this.yourRegexLbl.Text = "Регулярное выражение которое будет использовано для анализа:";
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.resultMemo);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 211);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(428, 228);
            this.resultGroupBox.TabIndex = 6;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Результаты";
            // 
            // resultMemo
            // 
            this.resultMemo.Location = new System.Drawing.Point(18, 25);
            this.resultMemo.Multiline = true;
            this.resultMemo.Name = "resultMemo";
            this.resultMemo.Size = new System.Drawing.Size(389, 189);
            this.resultMemo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 446);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.regexGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello people!";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.regexGroupBox.ResumeLayout(false);
            this.regexGroupBox.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button URLAnalyzeButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FileAnalyzeBtn;
        private System.Windows.Forms.GroupBox regexGroupBox;
        private System.Windows.Forms.TextBox userRegexTextBox;
        private System.Windows.Forms.Label yourRegexLbl;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.TextBox resultMemo;
    }
}

