namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Blue;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(0, 372);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Blue;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(75, 372);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Blue;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(147, 372);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(220, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 70);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operationClick);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Blue;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(220, 303);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(70, 70);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.operationClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Blue;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(147, 303);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Blue;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(75, 303);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Blue;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(0, 303);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numClick);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Blue;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(220, 165);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(70, 70);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.operationClick);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Blue;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(147, 165);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 70);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.delBtn);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(75, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 70);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.clearBtn);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Blue;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(0, 165);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(70, 70);
            this.btnClearAll.TabIndex = 12;
            this.btnClearAll.Text = "Clear History";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.clearHistory);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.Blue;
            this.btnMul.FlatAppearance.BorderSize = 0;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.ForeColor = System.Drawing.Color.White;
            this.btnMul.Location = new System.Drawing.Point(220, 234);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(70, 70);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.operationClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Blue;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(147, 234);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Blue;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(75, 234);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Blue;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(0, 234);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numClick);
            // 
            // btnAns
            // 
            this.btnAns.BackColor = System.Drawing.Color.Blue;
            this.btnAns.FlatAppearance.BorderSize = 0;
            this.btnAns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.ForeColor = System.Drawing.Color.White;
            this.btnAns.Location = new System.Drawing.Point(220, 440);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(70, 70);
            this.btnAns.TabIndex = 19;
            this.btnAns.Text = "=";
            this.btnAns.UseVisualStyleBackColor = false;
            this.btnAns.Click += new System.EventHandler(this.BtnAns_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Blue;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.White;
            this.btnPoint.Location = new System.Drawing.Point(147, 440);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(70, 70);
            this.btnPoint.TabIndex = 18;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.numClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Blue;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(75, 440);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.Blue;
            this.btnAbs.FlatAppearance.BorderSize = 0;
            this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbs.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.ForeColor = System.Drawing.Color.White;
            this.btnAbs.Location = new System.Drawing.Point(2, 439);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(70, 70);
            this.btnAbs.TabIndex = 16;
            this.btnAbs.Text = "!";
            this.btnAbs.UseVisualStyleBackColor = false;
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("Google Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.display.Size = new System.Drawing.Size(292, 165);
            this.display.TabIndex = 20;
            this.display.Text = "";
            this.display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(292, 511);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Calculator";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator_Roneet";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.RichTextBox display;
    }
}