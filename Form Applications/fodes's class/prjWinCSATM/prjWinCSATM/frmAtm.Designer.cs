namespace prjWinCSATM
{
    partial class frmAtm
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
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnNextNumber = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.btnNextPin = new System.Windows.Forms.Button();
            this.grbAccountTypes = new System.Windows.Forms.GroupBox();
            this.btnType = new System.Windows.Forms.Button();
            this.cbbAccounts = new System.Windows.Forms.ComboBox();
            this.lblSelectAccount = new System.Windows.Forms.Label();
            this.grbTransactions = new System.Windows.Forms.GroupBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.radConsult = new System.Windows.Forms.RadioButton();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.btnNextTransaction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.grbAccountTypes.SuspendLayout();
            this.grbTransactions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROYALE-BANK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATM";
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Location = new System.Drawing.Point(142, 114);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(110, 16);
            this.lblClientNumber.TabIndex = 2;
            this.lblClientNumber.Text = "Client number :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(258, 111);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(168, 22);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // btnNextNumber
            // 
            this.btnNextNumber.Location = new System.Drawing.Point(358, 139);
            this.btnNextNumber.Name = "btnNextNumber";
            this.btnNextNumber.Size = new System.Drawing.Size(88, 27);
            this.btnNextNumber.TabIndex = 4;
            this.btnNextNumber.Text = "Next >>";
            this.btnNextNumber.UseVisualStyleBackColor = true;
            this.btnNextNumber.Click += new System.EventHandler(this.btnNextNumber_Click);
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(24, 211);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(228, 21);
            this.lblClient.TabIndex = 5;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(258, 247);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(168, 22);
            this.txtPin.TabIndex = 7;
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Location = new System.Drawing.Point(147, 250);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(106, 16);
            this.lblEnterPin.TabIndex = 6;
            this.lblEnterPin.Text = "Enter the PIN :";
            // 
            // btnNextPin
            // 
            this.btnNextPin.Location = new System.Drawing.Point(358, 275);
            this.btnNextPin.Name = "btnNextPin";
            this.btnNextPin.Size = new System.Drawing.Size(88, 27);
            this.btnNextPin.TabIndex = 8;
            this.btnNextPin.Text = "Next >>";
            this.btnNextPin.UseVisualStyleBackColor = true;
            this.btnNextPin.Click += new System.EventHandler(this.btnNextPin_Click);
            // 
            // grbAccountTypes
            // 
            this.grbAccountTypes.Controls.Add(this.btnType);
            this.grbAccountTypes.Controls.Add(this.cbbAccounts);
            this.grbAccountTypes.Controls.Add(this.lblSelectAccount);
            this.grbAccountTypes.Location = new System.Drawing.Point(27, 320);
            this.grbAccountTypes.Name = "grbAccountTypes";
            this.grbAccountTypes.Size = new System.Drawing.Size(524, 102);
            this.grbAccountTypes.TabIndex = 9;
            this.grbAccountTypes.TabStop = false;
            this.grbAccountTypes.Text = "Account types";
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(331, 61);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(88, 27);
            this.btnType.TabIndex = 13;
            this.btnType.Text = "Next >>";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // cbbAccounts
            // 
            this.cbbAccounts.FormattingEnabled = true;
            this.cbbAccounts.Location = new System.Drawing.Point(231, 31);
            this.cbbAccounts.Name = "cbbAccounts";
            this.cbbAccounts.Size = new System.Drawing.Size(168, 24);
            this.cbbAccounts.TabIndex = 12;
            // 
            // lblSelectAccount
            // 
            this.lblSelectAccount.AutoSize = true;
            this.lblSelectAccount.Location = new System.Drawing.Point(103, 34);
            this.lblSelectAccount.Name = "lblSelectAccount";
            this.lblSelectAccount.Size = new System.Drawing.Size(122, 16);
            this.lblSelectAccount.TabIndex = 11;
            this.lblSelectAccount.Text = "Select account : ";
            // 
            // grbTransactions
            // 
            this.grbTransactions.Controls.Add(this.txtWithdraw);
            this.grbTransactions.Controls.Add(this.txtDeposit);
            this.grbTransactions.Controls.Add(this.radConsult);
            this.grbTransactions.Controls.Add(this.radWithdraw);
            this.grbTransactions.Controls.Add(this.radDeposit);
            this.grbTransactions.Controls.Add(this.btnNextTransaction);
            this.grbTransactions.Location = new System.Drawing.Point(27, 437);
            this.grbTransactions.Name = "grbTransactions";
            this.grbTransactions.Size = new System.Drawing.Size(524, 148);
            this.grbTransactions.TabIndex = 10;
            this.grbTransactions.TabStop = false;
            this.grbTransactions.Text = "Transactions";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(231, 68);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(111, 22);
            this.txtWithdraw.TabIndex = 18;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(231, 31);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(111, 22);
            this.txtDeposit.TabIndex = 17;
            // 
            // radConsult
            // 
            this.radConsult.AutoSize = true;
            this.radConsult.Location = new System.Drawing.Point(93, 103);
            this.radConsult.Name = "radConsult";
            this.radConsult.Size = new System.Drawing.Size(77, 20);
            this.radConsult.TabIndex = 16;
            this.radConsult.TabStop = true;
            this.radConsult.Text = "Consult";
            this.radConsult.UseVisualStyleBackColor = true;
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(93, 68);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(89, 20);
            this.radWithdraw.TabIndex = 15;
            this.radWithdraw.TabStop = true;
            this.radWithdraw.Text = "Withdraw";
            this.radWithdraw.UseVisualStyleBackColor = true;
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.Location = new System.Drawing.Point(93, 31);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(80, 20);
            this.radDeposit.TabIndex = 14;
            this.radDeposit.TabStop = true;
            this.radDeposit.Text = "Deposit";
            this.radDeposit.UseVisualStyleBackColor = true;
            // 
            // btnNextTransaction
            // 
            this.btnNextTransaction.Location = new System.Drawing.Point(331, 103);
            this.btnNextTransaction.Name = "btnNextTransaction";
            this.btnNextTransaction.Size = new System.Drawing.Size(88, 27);
            this.btnNextTransaction.TabIndex = 13;
            this.btnNextTransaction.Text = "Next >>";
            this.btnNextTransaction.UseVisualStyleBackColor = true;
            this.btnNextTransaction.Click += new System.EventHandler(this.btnNextTransaction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Location = new System.Drawing.Point(27, 601);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 84);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account information";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(43, 35);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(446, 21);
            this.lblInfo.TabIndex = 14;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(27, 705);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(524, 27);
            this.btnTerminate.TabIndex = 14;
            this.btnTerminate.Text = "TERMINATE";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // frmAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 747);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbTransactions);
            this.Controls.Add(this.grbAccountTypes);
            this.Controls.Add(this.btnNextPin);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblEnterPin);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnNextNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblClientNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAtm";
            this.Text = "ATM - Windows Application";
            this.Load += new System.EventHandler(this.frmAtm_Load);
            this.grbAccountTypes.ResumeLayout(false);
            this.grbAccountTypes.PerformLayout();
            this.grbTransactions.ResumeLayout(false);
            this.grbTransactions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnNextNumber;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.Button btnNextPin;
        private System.Windows.Forms.GroupBox grbAccountTypes;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.ComboBox cbbAccounts;
        private System.Windows.Forms.Label lblSelectAccount;
        private System.Windows.Forms.GroupBox grbTransactions;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.RadioButton radConsult;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.Button btnNextTransaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnTerminate;
    }
}

