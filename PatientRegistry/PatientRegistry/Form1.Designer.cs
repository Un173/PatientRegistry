namespace PatientRegistry
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Third = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysWithin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRetirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfLiving1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.лрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isLyingWithParentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bedProfileComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.placeOfLivingComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfEntryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dateOfRetirementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.endDateOfRetirementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateOfEntryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.lastName,
            this.firstName,
            this.patronymic,
            this.Second,
            this.Third,
            this.dateOfBirth,
            this.daysWithin,
            this.dateOfEntry,
            this.dateOfRetirement,
            this.placeOfLiving1,
            this.bedProfile,
            this.department,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Фамилия";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Имя";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // patronymic
            // 
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.Name = "patronymic";
            this.patronymic.ReadOnly = true;
            // 
            // Second
            // 
            this.Second.HeaderText = "Пол";
            this.Second.Name = "Second";
            this.Second.ReadOnly = true;
            // 
            // Third
            // 
            this.Third.HeaderText = "По уходу?";
            this.Third.Name = "Third";
            this.Third.ReadOnly = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.HeaderText = "Дата рождения";
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            // 
            // daysWithin
            // 
            this.daysWithin.HeaderText = "Количество койко-дней";
            this.daysWithin.Name = "daysWithin";
            this.daysWithin.ReadOnly = true;
            // 
            // dateOfEntry
            // 
            this.dateOfEntry.HeaderText = "Дата поступления";
            this.dateOfEntry.Name = "dateOfEntry";
            this.dateOfEntry.ReadOnly = true;
            // 
            // dateOfRetirement
            // 
            this.dateOfRetirement.HeaderText = "Дата выбытия";
            this.dateOfRetirement.Name = "dateOfRetirement";
            this.dateOfRetirement.ReadOnly = true;
            // 
            // placeOfLiving1
            // 
            this.placeOfLiving1.HeaderText = "Место проживания";
            this.placeOfLiving1.Name = "placeOfLiving1";
            this.placeOfLiving1.ReadOnly = true;
            // 
            // bedProfile
            // 
            this.bedProfile.HeaderText = "Профиль койки";
            this.bedProfile.Name = "bedProfile";
            this.bedProfile.ReadOnly = true;
            // 
            // department
            // 
            this.department.HeaderText = "Отделение";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // лрToolStripMenuItem
            // 
            this.лрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поступлениеToolStripMenuItem});
            this.лрToolStripMenuItem.Name = "лрToolStripMenuItem";
            this.лрToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.лрToolStripMenuItem.Text = "Движение больных";
            // 
            // поступлениеToolStripMenuItem
            // 
            this.поступлениеToolStripMenuItem.Name = "поступлениеToolStripMenuItem";
            this.поступлениеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.поступлениеToolStripMenuItem.Text = "Поступление";
            this.поступлениеToolStripMenuItem.Click += new System.EventHandler(this.поступлениеToolStripMenuItem_Click_1);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(77, 27);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(77, 53);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(77, 79);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(195, 20);
            this.patronymicTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пол:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Все",
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(77, 110);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Лежит ли с ним родитель?";
            // 
            // isLyingWithParentComboBox
            // 
            this.isLyingWithParentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isLyingWithParentComboBox.FormattingEnabled = true;
            this.isLyingWithParentComboBox.Items.AddRange(new object[] {
            "Все",
            "Нет",
            "Да"});
            this.isLyingWithParentComboBox.Location = new System.Drawing.Point(356, 110);
            this.isLyingWithParentComboBox.Name = "isLyingWithParentComboBox";
            this.isLyingWithParentComboBox.Size = new System.Drawing.Size(121, 21);
            this.isLyingWithParentComboBox.TabIndex = 12;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Все",
            "Педиатрическое №1",
            "Педиатрическое №2",
            "Патологии новорожденных №1",
            "Патологии новорожденных №2",
            "Неврологическое",
            "Реабилитация"});
            this.departmentComboBox.Location = new System.Drawing.Point(796, 88);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(195, 21);
            this.departmentComboBox.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(633, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Выберите отделение:";
            // 
            // bedProfileComboBox
            // 
            this.bedProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedProfileComboBox.FormattingEnabled = true;
            this.bedProfileComboBox.Items.AddRange(new object[] {
            "Все",
            "Педиатрия",
            "Патология новорожденных",
            "Неврология"});
            this.bedProfileComboBox.Location = new System.Drawing.Point(796, 61);
            this.bedProfileComboBox.Name = "bedProfileComboBox";
            this.bedProfileComboBox.Size = new System.Drawing.Size(195, 21);
            this.bedProfileComboBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Профиль койки:";
            // 
            // placeOfLivingComboBox
            // 
            this.placeOfLivingComboBox.FormattingEnabled = true;
            this.placeOfLivingComboBox.Location = new System.Drawing.Point(796, 24);
            this.placeOfLivingComboBox.Name = "placeOfLivingComboBox";
            this.placeOfLivingComboBox.Size = new System.Drawing.Size(195, 21);
            this.placeOfLivingComboBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Место жительства:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дата поступления:";
            // 
            // dateOfEntryDateTimePicker
            // 
            this.dateOfEntryDateTimePicker.Enabled = false;
            this.dateOfEntryDateTimePicker.Location = new System.Drawing.Point(123, 163);
            this.dateOfEntryDateTimePicker.Name = "dateOfEntryDateTimePicker";
            this.dateOfEntryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfEntryDateTimePicker.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Дата рождения:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Enabled = false;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(123, 137);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(633, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Статус:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Все",
            "Состоит",
            "Выписка",
            "Перевод в другое ЛПУ",
            "Смерть"});
            this.statusComboBox.Location = new System.Drawing.Point(796, 115);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(195, 21);
            this.statusComboBox.TabIndex = 35;
            this.statusComboBox.Visible = false;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(636, 158);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(113, 23);
            this.filterButton.TabIndex = 36;
            this.filterButton.Text = "Отфильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(774, 158);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(113, 23);
            this.clearFilterButton.TabIndex = 37;
            this.clearFilterButton.Text = "Очистить фильтр";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(914, 158);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(113, 23);
            this.saveToFileButton.TabIndex = 38;
            this.saveToFileButton.Text = "Сохранить в файл";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Дата выбытия:";
            // 
            // dateOfRetirementDateTimePicker
            // 
            this.dateOfRetirementDateTimePicker.Enabled = false;
            this.dateOfRetirementDateTimePicker.Location = new System.Drawing.Point(123, 190);
            this.dateOfRetirementDateTimePicker.Name = "dateOfRetirementDateTimePicker";
            this.dateOfRetirementDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfRetirementDateTimePicker.TabIndex = 39;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(330, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Все";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(330, 165);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 42;
            this.checkBox2.Text = "Все";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(329, 192);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(45, 17);
            this.checkBox3.TabIndex = 43;
            this.checkBox3.Text = "Все";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(587, 194);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(45, 17);
            this.checkBox6.TabIndex = 50;
            this.checkBox6.Text = "Все";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(588, 167);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(45, 17);
            this.checkBox5.TabIndex = 49;
            this.checkBox5.Text = "Все";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(588, 141);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(45, 17);
            this.checkBox4.TabIndex = 48;
            this.checkBox4.Text = "Все";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // endDateOfRetirementDateTimePicker
            // 
            this.endDateOfRetirementDateTimePicker.Enabled = false;
            this.endDateOfRetirementDateTimePicker.Location = new System.Drawing.Point(381, 192);
            this.endDateOfRetirementDateTimePicker.Name = "endDateOfRetirementDateTimePicker";
            this.endDateOfRetirementDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateOfRetirementDateTimePicker.TabIndex = 47;
            // 
            // endDateOfEntryDateTimePicker
            // 
            this.endDateOfEntryDateTimePicker.Enabled = false;
            this.endDateOfEntryDateTimePicker.Location = new System.Drawing.Point(381, 165);
            this.endDateOfEntryDateTimePicker.Name = "endDateOfEntryDateTimePicker";
            this.endDateOfEntryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateOfEntryDateTimePicker.TabIndex = 45;
            // 
            // endDateOfBirthDateTimePicker
            // 
            this.endDateOfBirthDateTimePicker.Enabled = false;
            this.endDateOfBirthDateTimePicker.Location = new System.Drawing.Point(381, 139);
            this.endDateOfBirthDateTimePicker.Name = "endDateOfBirthDateTimePicker";
            this.endDateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateOfBirthDateTimePicker.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 581);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.endDateOfRetirementDateTimePicker);
            this.Controls.Add(this.endDateOfEntryDateTimePicker);
            this.Controls.Add(this.endDateOfBirthDateTimePicker);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateOfRetirementDateTimePicker);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.clearFilterButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bedProfileComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.placeOfLivingComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateOfEntryDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isLyingWithParentComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem лрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поступлениеToolStripMenuItem;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox isLyingWithParentComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox bedProfileComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox placeOfLivingComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateOfEntryDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second;
        private System.Windows.Forms.DataGridViewTextBoxColumn Third;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysWithin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRetirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfLiving1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateOfRetirementDateTimePicker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DateTimePicker endDateOfRetirementDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateOfEntryDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateOfBirthDateTimePicker;
    }
}

