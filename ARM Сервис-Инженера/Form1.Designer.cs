namespace ARM_Сервис_Инженера
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreateCOM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SendMsg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.XML = new System.Windows.Forms.Button();
            this.DownloadXML = new System.Windows.Forms.Button();
            this.CFU = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Del = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Msg1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChDir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Dir = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reliz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konfig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DB_login = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DB_pwd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UP_pwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UP_login = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCOM
            // 
            this.CreateCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCOM.Location = new System.Drawing.Point(755, 261);
            this.CreateCOM.Name = "CreateCOM";
            this.CreateCOM.Size = new System.Drawing.Size(71, 23);
            this.CreateCOM.TabIndex = 0;
            this.CreateCOM.Text = "СОМ-соединение";
            this.CreateCOM.UseVisualStyleBackColor = true;
            this.CreateCOM.Visible = false;
            this.CreateCOM.Click += new System.EventHandler(this.CreateCOM_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(805, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "   ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            this.label2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Location = new System.Drawing.Point(755, 235);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Visible = false;
            // 
            // SendMsg
            // 
            this.SendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendMsg.Location = new System.Drawing.Point(755, 243);
            this.SendMsg.Name = "SendMsg";
            this.SendMsg.Size = new System.Drawing.Size(71, 25);
            this.SendMsg.TabIndex = 6;
            this.SendMsg.Text = "Отправить";
            this.SendMsg.UseVisualStyleBackColor = true;
            this.SendMsg.Visible = false;
            this.SendMsg.Click += new System.EventHandler(this.SendMsg_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(755, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XML
            // 
            this.XML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XML.Location = new System.Drawing.Point(755, 135);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(71, 30);
            this.XML.TabIndex = 8;
            this.XML.Text = "XML";
            this.XML.UseVisualStyleBackColor = true;
            this.XML.Visible = false;
            this.XML.Click += new System.EventHandler(this.XML_Click);
            // 
            // DownloadXML
            // 
            this.DownloadXML.Location = new System.Drawing.Point(755, 16);
            this.DownloadXML.Name = "DownloadXML";
            this.DownloadXML.Size = new System.Drawing.Size(71, 30);
            this.DownloadXML.TabIndex = 9;
            this.DownloadXML.Text = "v8cscdsc";
            this.DownloadXML.UseVisualStyleBackColor = true;
            this.DownloadXML.Visible = false;
            this.DownloadXML.Click += new System.EventHandler(this.DownloadXML_Click);
            // 
            // CFU
            // 
            this.CFU.Location = new System.Drawing.Point(755, 52);
            this.CFU.Name = "CFU";
            this.CFU.Size = new System.Drawing.Size(71, 30);
            this.CFU.TabIndex = 10;
            this.CFU.Text = "CFU";
            this.CFU.UseVisualStyleBackColor = true;
            this.CFU.Visible = false;
            this.CFU.Click += new System.EventHandler(this.CFU_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Del);
            this.tabPage2.Controls.Add(this.Add);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.Msg1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обновление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Del
            // 
            this.Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.Location = new System.Drawing.Point(542, 41);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(25, 25);
            this.Del.TabIndex = 30;
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(516, 41);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(25, 25);
            this.Add.TabIndex = 31;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(10, 520);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(558, 18);
            this.progressBar1.TabIndex = 29;
            this.progressBar1.Visible = false;
            // 
            // Msg1
            // 
            this.Msg1.AutoSize = true;
            this.Msg1.Location = new System.Drawing.Point(7, 41);
            this.Msg1.Name = "Msg1";
            this.Msg1.Size = new System.Drawing.Size(32, 13);
            this.Msg1.TabIndex = 28;
            this.Msg1.Text = "msg1";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(9, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(558, 30);
            this.button3.TabIndex = 27;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Up,
            this.Code,
            this.Konfig,
            this.Reliz,
            this.Platform,
            this.Address,
            this.User,
            this.Pass});
            this.dataGridView1.Location = new System.Drawing.Point(10, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(557, 127);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Информация о процессе обновления";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(221, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Загрузить список информационных баз";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Номер";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(9, 268);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(558, 124);
            this.textBox2.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ChDir
            // 
            this.ChDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChDir.Image = ((System.Drawing.Image)(resources.GetObject("ChDir.Image")));
            this.ChDir.Location = new System.Drawing.Point(242, 19);
            this.ChDir.Name = "ChDir";
            this.ChDir.Size = new System.Drawing.Size(25, 25);
            this.ChDir.TabIndex = 32;
            this.ChDir.UseVisualStyleBackColor = true;
            this.ChDir.Click += new System.EventHandler(this.ChDir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Каталог";
            // 
            // Dir
            // 
            this.Dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dir.Location = new System.Drawing.Point(92, 19);
            this.Dir.Name = "Dir";
            this.Dir.Size = new System.Drawing.Size(142, 22);
            this.Dir.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(92, 47);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(169, 22);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(92, 19);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(169, 22);
            this.Email.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-mail";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 431);
            this.tabControl1.TabIndex = 21;
            // 
            // Pass
            // 
            this.Pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.NullValue = null;
            this.Pass.DefaultCellStyle = dataGridViewCellStyle2;
            this.Pass.HeaderText = "Пароль";
            this.Pass.Name = "Pass";
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.HeaderText = "Логин";
            this.User.Name = "User";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Адрес ИБ";
            this.Address.Name = "Address";
            // 
            // Platform
            // 
            this.Platform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Platform.HeaderText = "Платформа";
            this.Platform.Name = "Platform";
            // 
            // Reliz
            // 
            this.Reliz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reliz.HeaderText = "Релиз";
            this.Reliz.Name = "Reliz";
            // 
            // Konfig
            // 
            this.Konfig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Konfig.HeaderText = "Конфигурация";
            this.Konfig.Name = "Konfig";
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Up
            // 
            this.Up.HeaderText = " ";
            this.Up.Name = "Up";
            this.Up.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Up.Width = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(140, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 81);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отправка письма";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.ChDir);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Dir);
            this.groupBox2.Location = new System.Drawing.Point(140, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 50);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // DB_login
            // 
            this.DB_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DB_login.Location = new System.Drawing.Point(92, 19);
            this.DB_login.Name = "DB_login";
            this.DB_login.Size = new System.Drawing.Size(168, 22);
            this.DB_login.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Логин";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(20, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Пароль";
            // 
            // DB_pwd
            // 
            this.DB_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DB_pwd.Location = new System.Drawing.Point(92, 45);
            this.DB_pwd.Name = "DB_pwd";
            this.DB_pwd.Size = new System.Drawing.Size(168, 22);
            this.DB_pwd.TabIndex = 37;
            this.DB_pwd.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.DB_pwd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.DB_login);
            this.groupBox3.Location = new System.Drawing.Point(140, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 77);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Подключение к базе данных";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(19, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Пароль";
            // 
            // UP_pwd
            // 
            this.UP_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.UP_pwd.Location = new System.Drawing.Point(91, 46);
            this.UP_pwd.Name = "UP_pwd";
            this.UP_pwd.Size = new System.Drawing.Size(168, 22);
            this.UP_pwd.TabIndex = 42;
            this.UP_pwd.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(19, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Логин";
            // 
            // UP_login
            // 
            this.UP_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.UP_login.Location = new System.Drawing.Point(91, 20);
            this.UP_login.Name = "UP_login";
            this.UP_login.Size = new System.Drawing.Size(168, 22);
            this.UP_login.TabIndex = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.UP_pwd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.UP_login);
            this.groupBox4.Location = new System.Drawing.Point(140, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 79);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Подключение к users.v8.1c.ru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateCOM);
            this.Controls.Add(this.CFU);
            this.Controls.Add(this.DownloadXML);
            this.Controls.Add(this.XML);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SendMsg);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ARM. Обновление типовых ИБ 1С на платформе 8.2 и 8.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SendMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button XML;
        private System.Windows.Forms.Button DownloadXML;
        private System.Windows.Forms.Button CFU;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Msg1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox Dir;
        private System.Windows.Forms.Button ChDir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Up;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reliz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UP_pwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UP_login;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DB_pwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DB_login;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

