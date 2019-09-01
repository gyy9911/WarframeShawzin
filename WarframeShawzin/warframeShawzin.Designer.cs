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
            this.ouputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meterDefBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.meterPerBarBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scaleBox = new System.Windows.Forms.ComboBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(205, 45);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(220, 645);
            this.inputBox.TabIndex = 0;
            // 
            // ouputBox
            // 
            this.ouputBox.Location = new System.Drawing.Point(450, 45);
            this.ouputBox.Multiline = true;
            this.ouputBox.Name = "ouputBox";
            this.ouputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ouputBox.Size = new System.Drawing.Size(235, 645);
            this.ouputBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入简谱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 24);
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
            this.meterDefBox.Location = new System.Drawing.Point(11, 133);
            this.meterDefBox.Name = "meterDefBox";
            this.meterDefBox.Size = new System.Drawing.Size(48, 23);
            this.meterDefBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "分音符为一拍";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "每小节";
            // 
            // meterPerBarBox
            // 
            this.meterPerBarBox.FormattingEnabled = true;
            this.meterPerBarBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "12",
            "16",
            "24",
            "32"});
            this.meterPerBarBox.Location = new System.Drawing.Point(70, 93);
            this.meterPerBarBox.Name = "meterPerBarBox";
            this.meterPerBarBox.Size = new System.Drawing.Size(48, 23);
            this.meterPerBarBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "拍";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 57);
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
            this.scaleBox.Location = new System.Drawing.Point(54, 54);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(121, 23);
            this.scaleBox.TabIndex = 10;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(12, 641);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(150, 35);
            this.runButton.TabIndex = 11;
            this.runButton.Text = "生成代码";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // warframeShawzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 702);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.meterPerBarBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meterDefBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ouputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "warframeShawzin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox ouputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox meterDefBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox meterPerBarBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox scaleBox;
        private System.Windows.Forms.Button runButton;
    }
}

