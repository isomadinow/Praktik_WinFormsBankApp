namespace WindowsFormsBankApp
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
            this.tabCreateBank = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxNameBank = new System.Windows.Forms.TextBox();
            this.buttonCreateBank = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.buttonRemoveDeposit = new System.Windows.Forms.Button();
            this.buttonRemoveCredit = new System.Windows.Forms.Button();
            this.buttonRemoveClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxDeposits = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.listBoxCredits = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.buttonShowDeposit = new System.Windows.Forms.Button();
            this.buttonShowCredit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShowClient = new System.Windows.Forms.Button();
            this.tabNewClient = new System.Windows.Forms.TabPage();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.tabNewCredit = new System.Windows.Forms.TabPage();
            this.numericLCreditLoan = new System.Windows.Forms.NumericUpDown();
            this.numericCreditPercent = new System.Windows.Forms.NumericUpDown();
            this.numericCreditSum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonAddCredit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCreditView = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCreditDate = new System.Windows.Forms.TextBox();
            this.tabNewDeposit = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDepositId = new System.Windows.Forms.TextBox();
            this.numericPercentDeposit = new System.Windows.Forms.NumericUpDown();
            this.numericSumDeposit = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonAddDeposit = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxViewDeposit = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxDateDeposit = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tabCreateBank.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabNewClient.SuspendLayout();
            this.tabNewCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLCreditLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCreditPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCreditSum)).BeginInit();
            this.tabNewDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercentDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSumDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCreateBank
            // 
            this.tabCreateBank.Controls.Add(this.pictureBoxLogo);
            this.tabCreateBank.Controls.Add(this.label15);
            this.tabCreateBank.Controls.Add(this.textBoxNameBank);
            this.tabCreateBank.Controls.Add(this.buttonCreateBank);
            this.tabCreateBank.Controls.Add(this.label2);
            this.tabCreateBank.Controls.Add(this.textBoxPhoneNumb);
            this.tabCreateBank.Controls.Add(this.label1);
            this.tabCreateBank.Controls.Add(this.textBoxAdress);
            this.tabCreateBank.Location = new System.Drawing.Point(4, 22);
            this.tabCreateBank.Name = "tabCreateBank";
            this.tabCreateBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateBank.Size = new System.Drawing.Size(739, 434);
            this.tabCreateBank.TabIndex = 0;
            this.tabCreateBank.Text = "Создание банка";
            this.tabCreateBank.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Введите название банка";
            // 
            // textBoxNameBank
            // 
            this.textBoxNameBank.Location = new System.Drawing.Point(128, 34);
            this.textBoxNameBank.Name = "textBoxNameBank";
            this.textBoxNameBank.Size = new System.Drawing.Size(371, 20);
            this.textBoxNameBank.TabIndex = 5;
            // 
            // buttonCreateBank
            // 
            this.buttonCreateBank.Location = new System.Drawing.Point(304, 147);
            this.buttonCreateBank.Name = "buttonCreateBank";
            this.buttonCreateBank.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateBank.TabIndex = 4;
            this.buttonCreateBank.Text = "Создать";
            this.buttonCreateBank.UseVisualStyleBackColor = true;
            this.buttonCreateBank.Click += new System.EventHandler(this.buttonCreateBank_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер телефона";
            // 
            // textBoxPhoneNumb
            // 
            this.textBoxPhoneNumb.Location = new System.Drawing.Point(128, 121);
            this.textBoxPhoneNumb.Name = "textBoxPhoneNumb";
            this.textBoxPhoneNumb.Size = new System.Drawing.Size(370, 20);
            this.textBoxPhoneNumb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите адрес";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(128, 73);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(371, 20);
            this.textBoxAdress.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabCreateBank);
            this.tabControlMain.Controls.Add(this.tabMain);
            this.tabControlMain.Controls.Add(this.tabNewClient);
            this.tabControlMain.Controls.Add(this.tabNewCredit);
            this.tabControlMain.Controls.Add(this.tabNewDeposit);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(747, 460);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.buttonRemoveDeposit);
            this.tabMain.Controls.Add(this.buttonRemoveCredit);
            this.tabMain.Controls.Add(this.buttonRemoveClient);
            this.tabMain.Controls.Add(this.label6);
            this.tabMain.Controls.Add(this.listBoxDeposits);
            this.tabMain.Controls.Add(this.label);
            this.tabMain.Controls.Add(this.listBoxCredits);
            this.tabMain.Controls.Add(this.label4);
            this.tabMain.Controls.Add(this.listBoxClient);
            this.tabMain.Controls.Add(this.buttonShowDeposit);
            this.tabMain.Controls.Add(this.buttonShowCredit);
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.buttonShowClient);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(739, 424);
            this.tabMain.TabIndex = 1;
            this.tabMain.Text = "Главное окно";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDeposit
            // 
            this.buttonRemoveDeposit.Location = new System.Drawing.Point(552, 317);
            this.buttonRemoveDeposit.Name = "buttonRemoveDeposit";
            this.buttonRemoveDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDeposit.TabIndex = 12;
            this.buttonRemoveDeposit.Text = "Удалить";
            this.buttonRemoveDeposit.UseVisualStyleBackColor = true;
            this.buttonRemoveDeposit.Click += new System.EventHandler(this.buttonRemoveDeposit_Click);
            // 
            // buttonRemoveCredit
            // 
            this.buttonRemoveCredit.Location = new System.Drawing.Point(342, 317);
            this.buttonRemoveCredit.Name = "buttonRemoveCredit";
            this.buttonRemoveCredit.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveCredit.TabIndex = 11;
            this.buttonRemoveCredit.Text = "Удалить";
            this.buttonRemoveCredit.UseVisualStyleBackColor = true;
            this.buttonRemoveCredit.Click += new System.EventHandler(this.buttonRemoveCredit_Click);
            // 
            // buttonRemoveClient
            // 
            this.buttonRemoveClient.Location = new System.Drawing.Point(132, 317);
            this.buttonRemoveClient.Name = "buttonRemoveClient";
            this.buttonRemoveClient.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveClient.TabIndex = 10;
            this.buttonRemoveClient.Text = "Удалить";
            this.buttonRemoveClient.UseVisualStyleBackColor = true;
            this.buttonRemoveClient.Click += new System.EventHandler(this.buttonRemoveClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Депозиты";
            // 
            // listBoxDeposits
            // 
            this.listBoxDeposits.FormattingEnabled = true;
            this.listBoxDeposits.Location = new System.Drawing.Point(423, 21);
            this.listBoxDeposits.Name = "listBoxDeposits";
            this.listBoxDeposits.Size = new System.Drawing.Size(204, 290);
            this.listBoxDeposits.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(213, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Кредиты";
            // 
            // listBoxCredits
            // 
            this.listBoxCredits.FormattingEnabled = true;
            this.listBoxCredits.Location = new System.Drawing.Point(213, 21);
            this.listBoxCredits.Name = "listBoxCredits";
            this.listBoxCredits.Size = new System.Drawing.Size(204, 290);
            this.listBoxCredits.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Клиенты";
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(3, 21);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(204, 290);
            this.listBoxClient.TabIndex = 4;
            // 
            // buttonShowDeposit
            // 
            this.buttonShowDeposit.Location = new System.Drawing.Point(216, 376);
            this.buttonShowDeposit.Name = "buttonShowDeposit";
            this.buttonShowDeposit.Size = new System.Drawing.Size(99, 42);
            this.buttonShowDeposit.TabIndex = 3;
            this.buttonShowDeposit.Text = "Депозита";
            this.buttonShowDeposit.UseVisualStyleBackColor = true;
            this.buttonShowDeposit.Click += new System.EventHandler(this.buttonShowDeposit_Click);
            // 
            // buttonShowCredit
            // 
            this.buttonShowCredit.Location = new System.Drawing.Point(108, 376);
            this.buttonShowCredit.Name = "buttonShowCredit";
            this.buttonShowCredit.Size = new System.Drawing.Size(99, 42);
            this.buttonShowCredit.TabIndex = 2;
            this.buttonShowCredit.Text = "Кредита";
            this.buttonShowCredit.UseVisualStyleBackColor = true;
            this.buttonShowCredit.Click += new System.EventHandler(this.buttonShowCredit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Показать инфо...";
            // 
            // buttonShowClient
            // 
            this.buttonShowClient.Location = new System.Drawing.Point(0, 376);
            this.buttonShowClient.Name = "buttonShowClient";
            this.buttonShowClient.Size = new System.Drawing.Size(99, 42);
            this.buttonShowClient.TabIndex = 0;
            this.buttonShowClient.Text = "Клиента";
            this.buttonShowClient.UseVisualStyleBackColor = true;
            this.buttonShowClient.Click += new System.EventHandler(this.buttonShowClient_Click);
            // 
            // tabNewClient
            // 
            this.tabNewClient.Controls.Add(this.buttonAddClient);
            this.tabNewClient.Controls.Add(this.label8);
            this.tabNewClient.Controls.Add(this.textBoxPhone);
            this.tabNewClient.Controls.Add(this.label7);
            this.tabNewClient.Controls.Add(this.textBoxPassport);
            this.tabNewClient.Controls.Add(this.label5);
            this.tabNewClient.Controls.Add(this.textBoxFIO);
            this.tabNewClient.Location = new System.Drawing.Point(4, 22);
            this.tabNewClient.Name = "tabNewClient";
            this.tabNewClient.Size = new System.Drawing.Size(739, 424);
            this.tabNewClient.TabIndex = 2;
            this.tabNewClient.Text = "Добавить клиента";
            this.tabNewClient.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(305, 128);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 8;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Номер телефона";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(9, 102);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(371, 20);
            this.textBoxPhone.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пасспорт";
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(8, 59);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(371, 20);
            this.textBoxPassport.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(8, 21);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(371, 20);
            this.textBoxFIO.TabIndex = 2;
            // 
            // tabNewCredit
            // 
            this.tabNewCredit.Controls.Add(this.numericLCreditLoan);
            this.tabNewCredit.Controls.Add(this.numericCreditPercent);
            this.tabNewCredit.Controls.Add(this.numericCreditSum);
            this.tabNewCredit.Controls.Add(this.label13);
            this.tabNewCredit.Controls.Add(this.label14);
            this.tabNewCredit.Controls.Add(this.buttonAddCredit);
            this.tabNewCredit.Controls.Add(this.label9);
            this.tabNewCredit.Controls.Add(this.label10);
            this.tabNewCredit.Controls.Add(this.textBoxCreditView);
            this.tabNewCredit.Controls.Add(this.label11);
            this.tabNewCredit.Controls.Add(this.textBoxCreditDate);
            this.tabNewCredit.Location = new System.Drawing.Point(4, 22);
            this.tabNewCredit.Name = "tabNewCredit";
            this.tabNewCredit.Size = new System.Drawing.Size(739, 424);
            this.tabNewCredit.TabIndex = 3;
            this.tabNewCredit.Text = "Добавить кредит";
            this.tabNewCredit.UseVisualStyleBackColor = true;
            // 
            // numericLCreditLoan
            // 
            this.numericLCreditLoan.Location = new System.Drawing.Point(10, 182);
            this.numericLCreditLoan.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericLCreditLoan.Name = "numericLCreditLoan";
            this.numericLCreditLoan.Size = new System.Drawing.Size(368, 20);
            this.numericLCreditLoan.TabIndex = 24;
            // 
            // numericCreditPercent
            // 
            this.numericCreditPercent.Location = new System.Drawing.Point(11, 144);
            this.numericCreditPercent.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericCreditPercent.Name = "numericCreditPercent";
            this.numericCreditPercent.Size = new System.Drawing.Size(368, 20);
            this.numericCreditPercent.TabIndex = 23;
            // 
            // numericCreditSum
            // 
            this.numericCreditSum.Location = new System.Drawing.Point(11, 100);
            this.numericCreditSum.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericCreditSum.Name = "numericCreditSum";
            this.numericCreditSum.Size = new System.Drawing.Size(368, 20);
            this.numericCreditSum.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Срок  погашения";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Процент";
            // 
            // buttonAddCredit
            // 
            this.buttonAddCredit.Location = new System.Drawing.Point(304, 208);
            this.buttonAddCredit.Name = "buttonAddCredit";
            this.buttonAddCredit.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCredit.TabIndex = 15;
            this.buttonAddCredit.Text = "Добавить";
            this.buttonAddCredit.UseVisualStyleBackColor = true;
            this.buttonAddCredit.Click += new System.EventHandler(this.buttonAddCredit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Сумма";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Вид";
            // 
            // textBoxCreditView
            // 
            this.textBoxCreditView.Location = new System.Drawing.Point(8, 57);
            this.textBoxCreditView.Name = "textBoxCreditView";
            this.textBoxCreditView.Size = new System.Drawing.Size(371, 20);
            this.textBoxCreditView.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Дата";
            // 
            // textBoxCreditDate
            // 
            this.textBoxCreditDate.Location = new System.Drawing.Point(8, 19);
            this.textBoxCreditDate.Name = "textBoxCreditDate";
            this.textBoxCreditDate.Size = new System.Drawing.Size(371, 20);
            this.textBoxCreditDate.TabIndex = 9;
            // 
            // tabNewDeposit
            // 
            this.tabNewDeposit.Controls.Add(this.label12);
            this.tabNewDeposit.Controls.Add(this.textBoxDepositId);
            this.tabNewDeposit.Controls.Add(this.numericPercentDeposit);
            this.tabNewDeposit.Controls.Add(this.numericSumDeposit);
            this.tabNewDeposit.Controls.Add(this.label17);
            this.tabNewDeposit.Controls.Add(this.buttonAddDeposit);
            this.tabNewDeposit.Controls.Add(this.label18);
            this.tabNewDeposit.Controls.Add(this.label19);
            this.tabNewDeposit.Controls.Add(this.textBoxViewDeposit);
            this.tabNewDeposit.Controls.Add(this.label20);
            this.tabNewDeposit.Controls.Add(this.textBoxDateDeposit);
            this.tabNewDeposit.Location = new System.Drawing.Point(4, 22);
            this.tabNewDeposit.Name = "tabNewDeposit";
            this.tabNewDeposit.Size = new System.Drawing.Size(739, 424);
            this.tabNewDeposit.TabIndex = 4;
            this.tabNewDeposit.Text = "Добавить депозит";
            this.tabNewDeposit.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Код";
            // 
            // textBoxDepositId
            // 
            this.textBoxDepositId.Location = new System.Drawing.Point(3, 99);
            this.textBoxDepositId.Name = "textBoxDepositId";
            this.textBoxDepositId.Size = new System.Drawing.Size(371, 20);
            this.textBoxDepositId.TabIndex = 36;
            // 
            // numericPercentDeposit
            // 
            this.numericPercentDeposit.Location = new System.Drawing.Point(3, 196);
            this.numericPercentDeposit.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericPercentDeposit.Name = "numericPercentDeposit";
            this.numericPercentDeposit.Size = new System.Drawing.Size(368, 20);
            this.numericPercentDeposit.TabIndex = 34;
            // 
            // numericSumDeposit
            // 
            this.numericSumDeposit.Location = new System.Drawing.Point(3, 147);
            this.numericSumDeposit.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericSumDeposit.Name = "numericSumDeposit";
            this.numericSumDeposit.Size = new System.Drawing.Size(368, 20);
            this.numericSumDeposit.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Процент";
            // 
            // buttonAddDeposit
            // 
            this.buttonAddDeposit.Location = new System.Drawing.Point(299, 239);
            this.buttonAddDeposit.Name = "buttonAddDeposit";
            this.buttonAddDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDeposit.TabIndex = 28;
            this.buttonAddDeposit.Text = "Добавить";
            this.buttonAddDeposit.UseVisualStyleBackColor = true;
            this.buttonAddDeposit.Click += new System.EventHandler(this.buttonAddDeposit_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Сумма";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Вид";
            // 
            // textBoxViewDeposit
            // 
            this.textBoxViewDeposit.Location = new System.Drawing.Point(3, 57);
            this.textBoxViewDeposit.Name = "textBoxViewDeposit";
            this.textBoxViewDeposit.Size = new System.Drawing.Size(371, 20);
            this.textBoxViewDeposit.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Дата";
            // 
            // textBoxDateDeposit
            // 
            this.textBoxDateDeposit.Location = new System.Drawing.Point(3, 19);
            this.textBoxDateDeposit.Name = "textBoxDateDeposit";
            this.textBoxDateDeposit.Size = new System.Drawing.Size(371, 20);
            this.textBoxDateDeposit.TabIndex = 22;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.ErrorImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(73, 176);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(514, 228);
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 460);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCreateBank.ResumeLayout(false);
            this.tabCreateBank.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabNewClient.ResumeLayout(false);
            this.tabNewClient.PerformLayout();
            this.tabNewCredit.ResumeLayout(false);
            this.tabNewCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLCreditLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCreditPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCreditSum)).EndInit();
            this.tabNewDeposit.ResumeLayout(false);
            this.tabNewDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercentDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSumDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button buttonCreateBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhoneNumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Button buttonRemoveDeposit;
        private System.Windows.Forms.Button buttonRemoveCredit;
        private System.Windows.Forms.Button buttonRemoveClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxDeposits;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBoxCredits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Button buttonShowDeposit;
        private System.Windows.Forms.Button buttonShowCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowClient;
        private System.Windows.Forms.TabPage tabNewClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TabPage tabNewCredit;
        private System.Windows.Forms.NumericUpDown numericLCreditLoan;
        private System.Windows.Forms.NumericUpDown numericCreditPercent;
        private System.Windows.Forms.NumericUpDown numericCreditSum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonAddCredit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCreditView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCreditDate;
        private System.Windows.Forms.TabPage tabNewDeposit;
        private System.Windows.Forms.NumericUpDown numericPercentDeposit;
        private System.Windows.Forms.NumericUpDown numericSumDeposit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonAddDeposit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxViewDeposit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxDateDeposit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxNameBank;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDepositId;
        private System.Windows.Forms.TabPage tabCreateBank;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

