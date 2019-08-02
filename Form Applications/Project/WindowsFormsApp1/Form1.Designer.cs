namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lottoGroup = new System.Windows.Forms.GroupBox();
            this.lottoLabel2 = new System.Windows.Forms.Label();
            this.lottoLabel = new System.Windows.Forms.Label();
            this.lottoBtn = new System.Windows.Forms.Button();
            this.lotto2Btn = new System.Windows.Forms.Button();
            this.convertionGroup = new System.Windows.Forms.GroupBox();
            this.tempratureLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyBtn = new System.Windows.Forms.Button();
            this.tempBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.caculatorLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lottoGroup.SuspendLayout();
            this.convertionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lottoGroup
            // 
            this.lottoGroup.Controls.Add(this.lottoLabel2);
            this.lottoGroup.Controls.Add(this.lottoLabel);
            this.lottoGroup.Controls.Add(this.lottoBtn);
            this.lottoGroup.Controls.Add(this.lotto2Btn);
            this.lottoGroup.Location = new System.Drawing.Point(55, 117);
            this.lottoGroup.Name = "lottoGroup";
            this.lottoGroup.Size = new System.Drawing.Size(270, 204);
            this.lottoGroup.TabIndex = 0;
            this.lottoGroup.TabStop = false;
            this.lottoGroup.Text = "Lotto";
            // 
            // lottoLabel2
            // 
            this.lottoLabel2.AutoSize = true;
            this.lottoLabel2.Location = new System.Drawing.Point(170, 175);
            this.lottoLabel2.Name = "lottoLabel2";
            this.lottoLabel2.Size = new System.Drawing.Size(55, 13);
            this.lottoLabel2.TabIndex = 5;
            this.lottoLabel2.Text = "Lotto 6-49";
            // 
            // lottoLabel
            // 
            this.lottoLabel.AutoSize = true;
            this.lottoLabel.Location = new System.Drawing.Point(44, 175);
            this.lottoLabel.Name = "lottoLabel";
            this.lottoLabel.Size = new System.Drawing.Size(54, 13);
            this.lottoLabel.TabIndex = 4;
            this.lottoLabel.Text = "Lotto Max";
            // 
            // lottoBtn
            // 
            this.lottoBtn.Image = ((System.Drawing.Image)(resources.GetObject("lottoBtn.Image")));
            this.lottoBtn.Location = new System.Drawing.Point(11, 26);
            this.lottoBtn.Name = "lottoBtn";
            this.lottoBtn.Size = new System.Drawing.Size(120, 140);
            this.lottoBtn.TabIndex = 2;
            this.lottoBtn.UseVisualStyleBackColor = true;
            this.lottoBtn.Click += new System.EventHandler(this.LottoBtn_Click);
            // 
            // lotto2Btn
            // 
            this.lotto2Btn.Image = ((System.Drawing.Image)(resources.GetObject("lotto2Btn.Image")));
            this.lotto2Btn.Location = new System.Drawing.Point(139, 26);
            this.lotto2Btn.Name = "lotto2Btn";
            this.lotto2Btn.Size = new System.Drawing.Size(120, 140);
            this.lotto2Btn.TabIndex = 3;
            this.lotto2Btn.UseVisualStyleBackColor = true;
            this.lotto2Btn.Click += new System.EventHandler(this.Lotto2Btn_Click);
            // 
            // convertionGroup
            // 
            this.convertionGroup.Controls.Add(this.tempratureLabel);
            this.convertionGroup.Controls.Add(this.moneyLabel);
            this.convertionGroup.Controls.Add(this.moneyBtn);
            this.convertionGroup.Controls.Add(this.tempBtn);
            this.convertionGroup.Location = new System.Drawing.Point(469, 117);
            this.convertionGroup.Name = "convertionGroup";
            this.convertionGroup.Size = new System.Drawing.Size(270, 204);
            this.convertionGroup.TabIndex = 4;
            this.convertionGroup.TabStop = false;
            this.convertionGroup.Text = "Convertions";
            // 
            // tempratureLabel
            // 
            this.tempratureLabel.AutoSize = true;
            this.tempratureLabel.Location = new System.Drawing.Point(142, 175);
            this.tempratureLabel.Name = "tempratureLabel";
            this.tempratureLabel.Size = new System.Drawing.Size(110, 13);
            this.tempratureLabel.TabIndex = 8;
            this.tempratureLabel.Text = "Temprature Converter";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(29, 175);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(90, 13);
            this.moneyLabel.TabIndex = 7;
            this.moneyLabel.Text = "Money Exchange";
            // 
            // moneyBtn
            // 
            this.moneyBtn.Image = ((System.Drawing.Image)(resources.GetObject("moneyBtn.Image")));
            this.moneyBtn.Location = new System.Drawing.Point(12, 23);
            this.moneyBtn.Name = "moneyBtn";
            this.moneyBtn.Size = new System.Drawing.Size(120, 140);
            this.moneyBtn.TabIndex = 2;
            this.moneyBtn.UseVisualStyleBackColor = true;
            this.moneyBtn.Click += new System.EventHandler(this.MoneyBtn_Click);
            // 
            // tempBtn
            // 
            this.tempBtn.Image = ((System.Drawing.Image)(resources.GetObject("tempBtn.Image")));
            this.tempBtn.Location = new System.Drawing.Point(138, 23);
            this.tempBtn.Name = "tempBtn";
            this.tempBtn.Size = new System.Drawing.Size(120, 140);
            this.tempBtn.TabIndex = 3;
            this.tempBtn.UseVisualStyleBackColor = true;
            this.tempBtn.Click += new System.EventHandler(this.TempBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Image = ((System.Drawing.Image)(resources.GetObject("calcBtn.Image")));
            this.calcBtn.Location = new System.Drawing.Point(336, 140);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(120, 140);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // caculatorLabel
            // 
            this.caculatorLabel.AutoSize = true;
            this.caculatorLabel.Location = new System.Drawing.Point(370, 288);
            this.caculatorLabel.Name = "caculatorLabel";
            this.caculatorLabel.Size = new System.Drawing.Size(54, 13);
            this.caculatorLabel.TabIndex = 6;
            this.caculatorLabel.Text = "Calculator";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(361, 504);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = " IPValidator";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(266, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 140);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.caculatorLabel);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.convertionGroup);
            this.Controls.Add(this.lottoGroup);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lottoGroup.ResumeLayout(false);
            this.lottoGroup.PerformLayout();
            this.convertionGroup.ResumeLayout(false);
            this.convertionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lottoGroup;
        private System.Windows.Forms.Label lottoLabel2;
        private System.Windows.Forms.Label lottoLabel;
        private System.Windows.Forms.Button lottoBtn;
        private System.Windows.Forms.Button lotto2Btn;
        private System.Windows.Forms.GroupBox convertionGroup;
        private System.Windows.Forms.Label tempratureLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button moneyBtn;
        private System.Windows.Forms.Button tempBtn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label caculatorLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

