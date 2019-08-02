namespace final_exam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age: ";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(192, 38);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(141, 20);
            this.fullName.TabIndex = 3;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(192, 82);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(141, 20);
            this.city.TabIndex = 4;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(192, 122);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(141, 20);
            this.age.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Write and Read User in Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "XML File Creation from text File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "Read XML File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(190, 256);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 300);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.city);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit;
    }
}

