namespace Final
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stuName = new System.Windows.Forms.TextBox();
            this.txt_courseNo = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_midTermMarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_finalMarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_projectMarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_finalPercentage = new System.Windows.Forms.TextBox();
            this.txt_projectPercentage = new System.Windows.Forms.TextBox();
            this.txt_midTermPercentage = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_totalPercentage = new System.Windows.Forms.TextBox();
            this.txt_totalGrades = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_calculateMarks = new System.Windows.Forms.Button();
            this.btn_fileWrite = new System.Windows.Forms.Button();
            this.btn_xmlWrite = new System.Windows.Forms.Button();
            this.btn_xmlRead = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_session = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Session:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // txt_stuName
            // 
            this.txt_stuName.Location = new System.Drawing.Point(153, 53);
            this.txt_stuName.MaxLength = 30;
            this.txt_stuName.Name = "txt_stuName";
            this.txt_stuName.Size = new System.Drawing.Size(566, 20);
            this.txt_stuName.TabIndex = 1;
            this.txt_stuName.Text = "Enter Your Name";
            // 
            // txt_courseNo
            // 
            this.txt_courseNo.Location = new System.Drawing.Point(153, 100);
            this.txt_courseNo.Name = "txt_courseNo";
            this.txt_courseNo.Size = new System.Drawing.Size(128, 20);
            this.txt_courseNo.TabIndex = 2;
            this.txt_courseNo.Text = "420-???-AS";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(591, 100);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(128, 20);
            this.txt_year.TabIndex = 4;
            this.txt_year.Text = "2018";
            // 
            // txt_midTermMarks
            // 
            this.txt_midTermMarks.Location = new System.Drawing.Point(69, 227);
            this.txt_midTermMarks.Name = "txt_midTermMarks";
            this.txt_midTermMarks.Size = new System.Drawing.Size(100, 20);
            this.txt_midTermMarks.TabIndex = 5;
            this.txt_midTermMarks.Text = "0";
            this.txt_midTermMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Midterm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Project";
            // 
            // txt_finalMarks
            // 
            this.txt_finalMarks.Location = new System.Drawing.Point(434, 227);
            this.txt_finalMarks.Name = "txt_finalMarks";
            this.txt_finalMarks.Size = new System.Drawing.Size(100, 20);
            this.txt_finalMarks.TabIndex = 7;
            this.txt_finalMarks.Text = "0";
            this.txt_finalMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Final";
            // 
            // txt_projectMarks
            // 
            this.txt_projectMarks.Location = new System.Drawing.Point(253, 227);
            this.txt_projectMarks.Name = "txt_projectMarks";
            this.txt_projectMarks.Size = new System.Drawing.Size(100, 20);
            this.txt_projectMarks.TabIndex = 6;
            this.txt_projectMarks.Text = "0";
            this.txt_projectMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "0 to 100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "0 to 100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "0 to 100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "0 to 40%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "0 to 30%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "0 to 30%";
            // 
            // txt_finalPercentage
            // 
            this.txt_finalPercentage.Location = new System.Drawing.Point(434, 306);
            this.txt_finalPercentage.Name = "txt_finalPercentage";
            this.txt_finalPercentage.ReadOnly = true;
            this.txt_finalPercentage.Size = new System.Drawing.Size(100, 20);
            this.txt_finalPercentage.TabIndex = 19;
            this.txt_finalPercentage.TabStop = false;
            this.txt_finalPercentage.Text = "0";
            this.txt_finalPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_projectPercentage
            // 
            this.txt_projectPercentage.Location = new System.Drawing.Point(253, 306);
            this.txt_projectPercentage.Name = "txt_projectPercentage";
            this.txt_projectPercentage.ReadOnly = true;
            this.txt_projectPercentage.Size = new System.Drawing.Size(100, 20);
            this.txt_projectPercentage.TabIndex = 18;
            this.txt_projectPercentage.TabStop = false;
            this.txt_projectPercentage.Text = "0";
            this.txt_projectPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_midTermPercentage
            // 
            this.txt_midTermPercentage.Location = new System.Drawing.Point(69, 306);
            this.txt_midTermPercentage.Name = "txt_midTermPercentage";
            this.txt_midTermPercentage.ReadOnly = true;
            this.txt_midTermPercentage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_midTermPercentage.Size = new System.Drawing.Size(100, 20);
            this.txt_midTermPercentage.TabIndex = 17;
            this.txt_midTermPercentage.TabStop = false;
            this.txt_midTermPercentage.Text = "0";
            this.txt_midTermPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(648, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Total";
            // 
            // txt_totalPercentage
            // 
            this.txt_totalPercentage.Location = new System.Drawing.Point(613, 227);
            this.txt_totalPercentage.Name = "txt_totalPercentage";
            this.txt_totalPercentage.ReadOnly = true;
            this.txt_totalPercentage.Size = new System.Drawing.Size(100, 20);
            this.txt_totalPercentage.TabIndex = 24;
            this.txt_totalPercentage.TabStop = false;
            this.txt_totalPercentage.Text = "0";
            this.txt_totalPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_totalGrades
            // 
            this.txt_totalGrades.Location = new System.Drawing.Point(613, 306);
            this.txt_totalGrades.Name = "txt_totalGrades";
            this.txt_totalGrades.ReadOnly = true;
            this.txt_totalGrades.Size = new System.Drawing.Size(100, 20);
            this.txt_totalGrades.TabIndex = 25;
            this.txt_totalGrades.TabStop = false;
            this.txt_totalGrades.Text = "0";
            this.txt_totalGrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(640, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "0 to 100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(630, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "A,B,C,D or F";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(615, 348);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "( 60 - 100 to Pass )";
            // 
            // btn_calculateMarks
            // 
            this.btn_calculateMarks.Location = new System.Drawing.Point(69, 438);
            this.btn_calculateMarks.Name = "btn_calculateMarks";
            this.btn_calculateMarks.Size = new System.Drawing.Size(90, 52);
            this.btn_calculateMarks.TabIndex = 8;
            this.btn_calculateMarks.Text = "Validate - Calculate Data";
            this.btn_calculateMarks.UseVisualStyleBackColor = true;
            this.btn_calculateMarks.Click += new System.EventHandler(this.Btn_calculateMarks_Click);
            // 
            // btn_fileWrite
            // 
            this.btn_fileWrite.Location = new System.Drawing.Point(208, 438);
            this.btn_fileWrite.Name = "btn_fileWrite";
            this.btn_fileWrite.Size = new System.Drawing.Size(90, 52);
            this.btn_fileWrite.TabIndex = 9;
            this.btn_fileWrite.Text = "Write/Add student data into Final.txt";
            this.btn_fileWrite.UseVisualStyleBackColor = true;
            this.btn_fileWrite.Click += new System.EventHandler(this.Btn_fileWrite_Click);
            // 
            // btn_xmlWrite
            // 
            this.btn_xmlWrite.Location = new System.Drawing.Point(349, 437);
            this.btn_xmlWrite.Name = "btn_xmlWrite";
            this.btn_xmlWrite.Size = new System.Drawing.Size(90, 52);
            this.btn_xmlWrite.TabIndex = 10;
            this.btn_xmlWrite.Text = "Create/Add Xml Final.xml file from text file";
            this.btn_xmlWrite.UseVisualStyleBackColor = true;
            this.btn_xmlWrite.Click += new System.EventHandler(this.Btn_xmlWrite_Click);
            // 
            // btn_xmlRead
            // 
            this.btn_xmlRead.Location = new System.Drawing.Point(489, 438);
            this.btn_xmlRead.Name = "btn_xmlRead";
            this.btn_xmlRead.Size = new System.Drawing.Size(90, 52);
            this.btn_xmlRead.TabIndex = 11;
            this.btn_xmlRead.Text = "Read Xml Final.xml file";
            this.btn_xmlRead.UseVisualStyleBackColor = true;
            this.btn_xmlRead.Click += new System.EventHandler(this.Btn_xmlRead_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(638, 466);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 33;
            this.btn_exit.TabStop = false;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // txt_session
            // 
            this.txt_session.FormattingEnabled = true;
            this.txt_session.Items.AddRange(new object[] {
            "Summer",
            "Winter",
            "Fall"});
            this.txt_session.Location = new System.Drawing.Point(386, 99);
            this.txt_session.Name = "txt_session";
            this.txt_session.Size = new System.Drawing.Size(121, 21);
            this.txt_session.TabIndex = 3;
            this.txt_session.Text = "Summer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.txt_session);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_xmlRead);
            this.Controls.Add(this.btn_xmlWrite);
            this.Controls.Add(this.btn_fileWrite);
            this.Controls.Add(this.btn_calculateMarks);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_totalGrades);
            this.Controls.Add(this.txt_totalPercentage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_finalPercentage);
            this.Controls.Add(this.txt_projectPercentage);
            this.Controls.Add(this.txt_midTermPercentage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_projectMarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_finalMarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_midTermMarks);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_courseNo);
            this.Controls.Add(this.txt_stuName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Roneet Kumar - 20181927";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stuName;
        private System.Windows.Forms.TextBox txt_courseNo;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_midTermMarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_finalMarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_projectMarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_finalPercentage;
        private System.Windows.Forms.TextBox txt_projectPercentage;
        private System.Windows.Forms.TextBox txt_midTermPercentage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_totalPercentage;
        private System.Windows.Forms.TextBox txt_totalGrades;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_calculateMarks;
        private System.Windows.Forms.Button btn_fileWrite;
        private System.Windows.Forms.Button btn_xmlWrite;
        private System.Windows.Forms.Button btn_xmlRead;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox txt_session;
    }
}

