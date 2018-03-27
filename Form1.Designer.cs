namespace Clinic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnAddPat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDep = new System.Windows.Forms.Label();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.dgvPat = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPro = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDecs = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cbEventDoc = new System.Windows.Forms.ComboBox();
            this.cbEventPro = new System.Windows.Forms.ComboBox();
            this.cbEventPat = new System.Windows.Forms.ComboBox();
            this.btnAdd4 = new System.Windows.Forms.Button();
            this.lblSDoc = new System.Windows.Forms.Label();
            this.lblSPat = new System.Windows.Forms.Label();
            this.lblSPro = new System.Windows.Forms.Label();
            this.dgvNewEvent = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.dgvShowAll = new System.Windows.Forms.DataGridView();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test1 = new System.Windows.Forms.NumericUpDown();
            this.test2 = new System.Windows.Forms.NumericUpDown();
            this.test3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDoc.Location = new System.Drawing.Point(23, 13);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(265, 80);
            this.btnAddDoc.TabIndex = 0;
            this.btnAddDoc.Text = "+ Add Doctor";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnAddPat
            // 
            this.btnAddPat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPat.Location = new System.Drawing.Point(23, 117);
            this.btnAddPat.Name = "btnAddPat";
            this.btnAddPat.Size = new System.Drawing.Size(265, 80);
            this.btnAddPat.TabIndex = 1;
            this.btnAddPat.Text = "+ Add Patient";
            this.btnAddPat.UseVisualStyleBackColor = true;
            this.btnAddPat.Click += new System.EventHandler(this.btnAddPat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(23, 430);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(403, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPro.Location = new System.Drawing.Point(23, 224);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(265, 80);
            this.btnAddPro.TabIndex = 2;
            this.btnAddPro.Text = "+ Add Procedure";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = global::Clinic.Properties.Resources.sh_hospital;
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(320, 24);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(559, 291);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddEvent.Location = new System.Drawing.Point(23, 360);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(856, 49);
            this.btnAddEvent.TabIndex = 5;
            this.btnAddEvent.Text = "Add New Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(34, 98);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(309, 20);
            this.tbFullName.TabIndex = 6;
            this.tbFullName.Visible = false;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(34, 233);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(309, 20);
            this.tbPosition.TabIndex = 7;
            this.tbPosition.Visible = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(166, 64);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.Visible = false;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(166, 207);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Position";
            this.lblPosition.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDocs
            // 
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDocs.Location = new System.Drawing.Point(383, 23);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.Size = new System.Drawing.Size(495, 291);
            this.dgvDocs.TabIndex = 11;
            this.dgvDocs.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Department";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Position";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(475, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(403, 49);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(166, 131);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(62, 13);
            this.lblDep.TabIndex = 14;
            this.lblDep.Text = "Department";
            this.lblDep.Visible = false;
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Items.AddRange(new object[] {
            "Allergy/Immunology",
            "Cardiology",
            "Endocrinology",
            "Hematology/Oncology",
            "Nephrology"});
            this.cbDep.Location = new System.Drawing.Point(34, 175);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(309, 21);
            this.cbDep.TabIndex = 15;
            this.cbDep.Visible = false;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(34, 149);
            this.tbAge.MaxLength = 3;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 16;
            this.tbAge.Visible = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(69, 131);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age";
            this.lblAge.Visible = false;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(187, 147);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(156, 20);
            this.tbPhone.TabIndex = 18;
            this.tbPhone.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(249, 131);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone";
            this.lblPhone.Visible = false;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(94, 280);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 20;
            this.btnAdd2.Text = "ADD";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Visible = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // dgvPat
            // 
            this.dgvPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvPat.Location = new System.Drawing.Point(383, 33);
            this.dgvPat.Name = "dgvPat";
            this.dgvPat.Size = new System.Drawing.Size(495, 281);
            this.dgvPat.TabIndex = 21;
            this.dgvPat.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Name";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Age";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Phone";
            this.Column9.Name = "Column9";
            this.Column9.Width = 300;
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(55, 359);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(75, 23);
            this.btnAdd3.TabIndex = 22;
            this.btnAdd3.Text = "ADD";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Visible = false;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(134, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // tbPro
            // 
            this.tbPro.Location = new System.Drawing.Point(47, 108);
            this.tbPro.Name = "tbPro";
            this.tbPro.Size = new System.Drawing.Size(225, 20);
            this.tbPro.TabIndex = 24;
            this.tbPro.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(138, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            this.lblPrice.Visible = false;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(47, 184);
            this.nudPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(225, 20);
            this.nudPrice.TabIndex = 27;
            this.nudPrice.Visible = false;
            // 
            // dgvPro
            // 
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPro.Location = new System.Drawing.Point(369, 33);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.Size = new System.Drawing.Size(495, 281);
            this.dgvPro.TabIndex = 28;
            this.dgvPro.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            this.Column6.Width = 300;
            // 
            // tbDecs
            // 
            this.tbDecs.Location = new System.Drawing.Point(47, 280);
            this.tbDecs.Name = "tbDecs";
            this.tbDecs.Size = new System.Drawing.Size(225, 20);
            this.tbDecs.TabIndex = 29;
            this.tbDecs.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(134, 257);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 30;
            this.lblDesc.Text = "Description";
            this.lblDesc.Visible = false;
            // 
            // cbEventDoc
            // 
            this.cbEventDoc.FormattingEnabled = true;
            this.cbEventDoc.Location = new System.Drawing.Point(47, 135);
            this.cbEventDoc.Name = "cbEventDoc";
            this.cbEventDoc.Size = new System.Drawing.Size(225, 21);
            this.cbEventDoc.TabIndex = 31;
            this.cbEventDoc.Visible = false;
            // 
            // cbEventPro
            // 
            this.cbEventPro.FormattingEnabled = true;
            this.cbEventPro.Location = new System.Drawing.Point(47, 273);
            this.cbEventPro.Name = "cbEventPro";
            this.cbEventPro.Size = new System.Drawing.Size(225, 21);
            this.cbEventPro.TabIndex = 32;
            this.cbEventPro.Visible = false;
            // 
            // cbEventPat
            // 
            this.cbEventPat.FormattingEnabled = true;
            this.cbEventPat.Location = new System.Drawing.Point(47, 207);
            this.cbEventPat.Name = "cbEventPat";
            this.cbEventPat.Size = new System.Drawing.Size(225, 21);
            this.cbEventPat.TabIndex = 33;
            this.cbEventPat.Visible = false;
            // 
            // btnAdd4
            // 
            this.btnAdd4.Location = new System.Drawing.Point(55, 330);
            this.btnAdd4.Name = "btnAdd4";
            this.btnAdd4.Size = new System.Drawing.Size(75, 23);
            this.btnAdd4.TabIndex = 34;
            this.btnAdd4.Text = "ADD";
            this.btnAdd4.UseVisualStyleBackColor = true;
            this.btnAdd4.Visible = false;
            this.btnAdd4.Click += new System.EventHandler(this.btnAdd4_Click);
            // 
            // lblSDoc
            // 
            this.lblSDoc.AutoSize = true;
            this.lblSDoc.Location = new System.Drawing.Point(72, 116);
            this.lblSDoc.Name = "lblSDoc";
            this.lblSDoc.Size = new System.Drawing.Size(72, 13);
            this.lblSDoc.TabIndex = 35;
            this.lblSDoc.Text = "Select Doctor";
            this.lblSDoc.Visible = false;
            // 
            // lblSPat
            // 
            this.lblSPat.AutoSize = true;
            this.lblSPat.Location = new System.Drawing.Point(69, 183);
            this.lblSPat.Name = "lblSPat";
            this.lblSPat.Size = new System.Drawing.Size(73, 13);
            this.lblSPat.TabIndex = 36;
            this.lblSPat.Text = "Select Patient";
            this.lblSPat.Visible = false;
            // 
            // lblSPro
            // 
            this.lblSPro.AutoSize = true;
            this.lblSPro.Location = new System.Drawing.Point(72, 243);
            this.lblSPro.Name = "lblSPro";
            this.lblSPro.Size = new System.Drawing.Size(89, 13);
            this.lblSPro.TabIndex = 37;
            this.lblSPro.Text = "Select Procedure";
            this.lblSPro.Visible = false;
            // 
            // dgvNewEvent
            // 
            this.dgvNewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvNewEvent.Location = new System.Drawing.Point(383, 23);
            this.dgvNewEvent.Name = "dgvNewEvent";
            this.dgvNewEvent.Size = new System.Drawing.Size(495, 291);
            this.dgvNewEvent.TabIndex = 38;
            this.dgvNewEvent.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Date";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Doctor";
            this.Column11.Name = "Column11";
            this.Column11.Width = 115;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Patient";
            this.Column12.Name = "Column12";
            this.Column12.Width = 115;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Procedure";
            this.Column13.Name = "Column13";
            this.Column13.Width = 120;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAll.Location = new System.Drawing.Point(23, 430);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(856, 49);
            this.btnShowAll.TabIndex = 39;
            this.btnShowAll.Text = "Show All Events";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dtpEvent
            // 
            this.dtpEvent.CustomFormat = "dd.MM.yyyy";
            this.dtpEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent.Location = new System.Drawing.Point(47, 64);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(225, 20);
            this.dtpEvent.TabIndex = 40;
            this.dtpEvent.Visible = false;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(72, 46);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(63, 13);
            this.lblEventDate.TabIndex = 41;
            this.lblEventDate.Text = "Select Date";
            this.lblEventDate.Visible = false;
            // 
            // dgvShowAll
            // 
            this.dgvShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column17,
            this.Column14,
            this.Column21,
            this.Column22,
            this.Column15,
            this.Column20,
            this.Column19,
            this.Column16,
            this.Column23,
            this.Column18});
            this.dgvShowAll.Location = new System.Drawing.Point(8, 12);
            this.dgvShowAll.Name = "dgvShowAll";
            this.dgvShowAll.Size = new System.Drawing.Size(888, 411);
            this.dgvShowAll.TabIndex = 42;
            this.dgvShowAll.Visible = false;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Date";
            this.Column17.Name = "Column17";
            this.Column17.Width = 80;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Doctor";
            this.Column14.Name = "Column14";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Department";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Position";
            this.Column22.Name = "Column22";
            this.Column22.Width = 70;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Patient";
            this.Column15.Name = "Column15";
            this.Column15.Width = 90;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Patient Age";
            this.Column20.Name = "Column20";
            this.Column20.Width = 50;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Patient Number";
            this.Column19.Name = "Column19";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Procedur";
            this.Column16.Name = "Column16";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Description";
            this.Column23.Name = "Column23";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Price";
            this.Column18.Name = "Column18";
            this.Column18.Width = 50;
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(594, 250);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(120, 20);
            this.test1.TabIndex = 43;
            this.test1.Visible = false;
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(594, 284);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(120, 20);
            this.test2.TabIndex = 44;
            this.test2.Visible = false;
            // 
            // test3
            // 
            this.test3.Location = new System.Drawing.Point(594, 321);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(120, 20);
            this.test3.TabIndex = 45;
            this.test3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 486);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSPro);
            this.Controls.Add(this.lblSPat);
            this.Controls.Add(this.cbEventPat);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.tbDecs);
            this.Controls.Add(this.dgvNewEvent);
            this.Controls.Add(this.dgvPat);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.btnAdd4);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.dtpEvent);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.lblSDoc);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.btnAddPat);
            this.Controls.Add(this.tbPro);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.cbEventPro);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.cbDep);
            this.Controls.Add(this.cbEventDoc);
            this.Controls.Add(this.dgvDocs);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dgvPro);
            this.Controls.Add(this.dgvShowAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACRED HEART HOSPITAL";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Button btnAddPat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.DataGridView dgvPat;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPro;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox tbDecs;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ComboBox cbEventDoc;
        private System.Windows.Forms.ComboBox cbEventPro;
        private System.Windows.Forms.ComboBox cbEventPat;
        private System.Windows.Forms.Button btnAdd4;
        private System.Windows.Forms.Label lblSDoc;
        private System.Windows.Forms.Label lblSPat;
        private System.Windows.Forms.Label lblSPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dgvNewEvent;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridView dgvShowAll;
        private System.Windows.Forms.NumericUpDown test1;
        private System.Windows.Forms.NumericUpDown test2;
        private System.Windows.Forms.NumericUpDown test3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
    }
}

