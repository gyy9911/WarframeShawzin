namespace WarframeShawzin
{
    partial class warframeShawzin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meterDefBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scaleBox = new System.Windows.Forms.ComboBox();
            this.runButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(311, 31);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(249, 520);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(585, 31);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(235, 520);
            this.outputBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入简谱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出代码";
            // 
            // meterDefBox
            // 
            this.meterDefBox.FormattingEnabled = true;
            this.meterDefBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.meterDefBox.Location = new System.Drawing.Point(12, 106);
            this.meterDefBox.Name = "meterDefBox";
            this.meterDefBox.Size = new System.Drawing.Size(48, 23);
            this.meterDefBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "分音符为一拍";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "音阶";
            // 
            // scaleBox
            // 
            this.scaleBox.AutoCompleteCustomSource.AddRange(new string[] {
            "五声小调 ",
            "五声大调 ",
            "半音",
            "六式音阶",
            "大调",
            "小调",
            "平调子",
            "弗吉利亚调式"});
            this.scaleBox.FormattingEnabled = true;
            this.scaleBox.Items.AddRange(new object[] {
            "五声小调 ",
            "五声大调",
            "半音",
            "六式音阶",
            "大调",
            "小调",
            "平调子",
            "弗吉利亚调式"});
            this.scaleBox.Location = new System.Drawing.Point(52, 68);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(121, 23);
            this.scaleBox.TabIndex = 10;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(10, 516);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(150, 35);
            this.runButton.TabIndex = 11;
            this.runButton.Text = "生成代码";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "音符对应代码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "1 2 3 4 5 6 7";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "·······";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "·······";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "1 2 3 4 5 6 7   ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "=C D E F G A B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "=c d e f g a b";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "1 2 3 4 5 6 7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "=1 2 3 4 5 6 7";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(12, 16);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(150, 35);
            this.buttonHelp.TabIndex = 21;
            this.buttonHelp.Text = "使用说明";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(162, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "(双高音1）=h";
            // 
            // warframeShawzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meterDefBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "warframeShawzin";
            this.Text = "Warframe三弦琴代码转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox meterDefBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox scaleBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label14;
    }
}

