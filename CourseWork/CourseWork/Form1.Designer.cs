namespace CourseWork
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
            this.fio = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.TextBox();
            this.sal = new System.Windows.Forms.TextBox();
            this.qual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.recordsCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addHuman = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.newValue = new System.Windows.Forms.TextBox();
            this.editNumber = new System.Windows.Forms.TextBox();
            this.chooseEdit = new System.Windows.Forms.DomainUpDown();
            this.editRecord = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.readFromFile = new System.Windows.Forms.Button();
            this.deleteField = new System.Windows.Forms.Button();
            this.saveToFile = new System.Windows.Forms.Button();
            this.deleteNumber = new System.Windows.Forms.TextBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.filterQual = new System.Windows.Forms.TextBox();
            this.filterExp = new System.Windows.Forms.TextBox();
            this.filterRecords = new System.Windows.Forms.Button();
            this.sortItems = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.findItems = new System.Windows.Forms.Button();
            this.searchFio = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseSort = new System.Windows.Forms.DomainUpDown();
            this.resetAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aboutApp = new System.Windows.Forms.Button();
            this.resetProfessions = new System.Windows.Forms.Button();
            this.chooseForProfession = new System.Windows.Forms.DomainUpDown();
            this.sortProfessions = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.filterProfessions = new System.Windows.Forms.Button();
            this.profession = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fio
            // 
            this.fio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fio.Location = new System.Drawing.Point(150, 39);
            this.fio.Margin = new System.Windows.Forms.Padding(2);
            this.fio.MaxLength = 20;
            this.fio.MinimumSize = new System.Drawing.Size(114, 4);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(132, 20);
            this.fio.TabIndex = 0;
            this.fio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fio_MouseMove);
            // 
            // exp
            // 
            this.exp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exp.Location = new System.Drawing.Point(150, 61);
            this.exp.Margin = new System.Windows.Forms.Padding(2);
            this.exp.MaximumSize = new System.Drawing.Size(226, 4);
            this.exp.MaxLength = 2;
            this.exp.MinimumSize = new System.Drawing.Size(114, 4);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(132, 20);
            this.exp.TabIndex = 1;
            this.exp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exp_MouseMove);
            // 
            // adr
            // 
            this.adr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adr.Location = new System.Drawing.Point(150, 144);
            this.adr.Margin = new System.Windows.Forms.Padding(2);
            this.adr.MaxLength = 20;
            this.adr.MinimumSize = new System.Drawing.Size(114, 4);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(132, 20);
            this.adr.TabIndex = 3;
            this.adr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adr_MouseMove);
            // 
            // sal
            // 
            this.sal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sal.Location = new System.Drawing.Point(150, 167);
            this.sal.Margin = new System.Windows.Forms.Padding(2);
            this.sal.MaximumSize = new System.Drawing.Size(226, 4);
            this.sal.MaxLength = 6;
            this.sal.MinimumSize = new System.Drawing.Size(114, 4);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(132, 20);
            this.sal.TabIndex = 4;
            this.sal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sal_MouseMove);
            // 
            // qual
            // 
            this.qual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.qual.Location = new System.Drawing.Point(150, 84);
            this.qual.Margin = new System.Windows.Forms.Padding(2);
            this.qual.MaxLength = 20;
            this.qual.MinimumSize = new System.Drawing.Size(114, 4);
            this.qual.Name = "qual";
            this.qual.Size = new System.Drawing.Size(132, 20);
            this.qual.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО безработного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Стаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MaximumSize = new System.Drawing.Size(150, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Желание работать по специальности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Место расположения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Размер заработной платы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Профессия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(15, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Количество записей в базе";
            // 
            // recordsCount
            // 
            this.recordsCount.Location = new System.Drawing.Point(161, 7);
            this.recordsCount.Margin = new System.Windows.Forms.Padding(2);
            this.recordsCount.Name = "recordsCount";
            this.recordsCount.ReadOnly = true;
            this.recordsCount.Size = new System.Drawing.Size(132, 20);
            this.recordsCount.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Добавление новой информации";
            // 
            // addHuman
            // 
            this.addHuman.Location = new System.Drawing.Point(7, 200);
            this.addHuman.Margin = new System.Windows.Forms.Padding(2);
            this.addHuman.MinimumSize = new System.Drawing.Size(112, 0);
            this.addHuman.Name = "addHuman";
            this.addHuman.Size = new System.Drawing.Size(275, 19);
            this.addHuman.TabIndex = 16;
            this.addHuman.Text = "Добавить данные";
            this.addHuman.UseVisualStyleBackColor = true;
            this.addHuman.Click += new System.EventHandler(this.addHuman_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Редактирование данных";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Запись";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 294);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Изменяемый параметр";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 316);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Новое значение";
            // 
            // newValue
            // 
            this.newValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.newValue.Location = new System.Drawing.Point(150, 316);
            this.newValue.Margin = new System.Windows.Forms.Padding(2);
            this.newValue.MaxLength = 20;
            this.newValue.Name = "newValue";
            this.newValue.Size = new System.Drawing.Size(132, 20);
            this.newValue.TabIndex = 21;
            this.newValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.newValue_MouseMove);
            // 
            // editNumber
            // 
            this.editNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.editNumber.Location = new System.Drawing.Point(150, 271);
            this.editNumber.Margin = new System.Windows.Forms.Padding(2);
            this.editNumber.MaxLength = 4;
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(132, 20);
            this.editNumber.TabIndex = 23;
            this.editNumber.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editNumber_MouseMove);
            // 
            // chooseEdit
            // 
            this.chooseEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseEdit.Items.Add("ФИО");
            this.chooseEdit.Items.Add("Стаж");
            this.chooseEdit.Items.Add("Профессия");
            this.chooseEdit.Items.Add("Желание работать по специальности");
            this.chooseEdit.Items.Add("Место расположения");
            this.chooseEdit.Items.Add("Заработная плата");
            this.chooseEdit.Location = new System.Drawing.Point(150, 294);
            this.chooseEdit.Margin = new System.Windows.Forms.Padding(2);
            this.chooseEdit.MinimumSize = new System.Drawing.Size(131, 0);
            this.chooseEdit.Name = "chooseEdit";
            this.chooseEdit.Size = new System.Drawing.Size(132, 20);
            this.chooseEdit.TabIndex = 25;
            this.chooseEdit.Text = "Выбрать";
            this.chooseEdit.Wrap = true;
            // 
            // editRecord
            // 
            this.editRecord.Location = new System.Drawing.Point(7, 349);
            this.editRecord.Margin = new System.Windows.Forms.Padding(2);
            this.editRecord.MinimumSize = new System.Drawing.Size(112, 0);
            this.editRecord.Name = "editRecord";
            this.editRecord.Size = new System.Drawing.Size(275, 19);
            this.editRecord.TabIndex = 26;
            this.editRecord.Text = "Редактировать данные";
            this.editRecord.UseVisualStyleBackColor = true;
            this.editRecord.Click += new System.EventHandler(this.editRecord_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(148, 398);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Работа с файлом";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(4, 398);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Удаление данных";
            // 
            // readFromFile
            // 
            this.readFromFile.Location = new System.Drawing.Point(150, 447);
            this.readFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.readFromFile.MinimumSize = new System.Drawing.Size(131, 0);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(131, 20);
            this.readFromFile.TabIndex = 29;
            this.readFromFile.Text = "Прочитать из файла";
            this.readFromFile.UseVisualStyleBackColor = true;
            this.readFromFile.Click += new System.EventHandler(this.readFromFile_Click);
            // 
            // deleteField
            // 
            this.deleteField.Location = new System.Drawing.Point(6, 447);
            this.deleteField.Margin = new System.Windows.Forms.Padding(2);
            this.deleteField.MinimumSize = new System.Drawing.Size(131, 0);
            this.deleteField.Name = "deleteField";
            this.deleteField.Size = new System.Drawing.Size(132, 20);
            this.deleteField.TabIndex = 30;
            this.deleteField.Text = "Удалить данные";
            this.deleteField.UseVisualStyleBackColor = true;
            this.deleteField.Click += new System.EventHandler(this.deleteField_Click);
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(150, 424);
            this.saveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.saveToFile.MinimumSize = new System.Drawing.Size(131, 0);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(131, 20);
            this.saveToFile.TabIndex = 31;
            this.saveToFile.Text = "Сохранить в файл";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // deleteNumber
            // 
            this.deleteNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deleteNumber.Location = new System.Drawing.Point(6, 423);
            this.deleteNumber.Margin = new System.Windows.Forms.Padding(2);
            this.deleteNumber.MaxLength = 4;
            this.deleteNumber.MinimumSize = new System.Drawing.Size(132, 4);
            this.deleteNumber.Name = "deleteNumber";
            this.deleteNumber.Size = new System.Drawing.Size(132, 20);
            this.deleteNumber.TabIndex = 32;
            this.deleteNumber.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deleteNumber_MouseMove);
            // 
            // deleteAll
            // 
            this.deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAll.Location = new System.Drawing.Point(6, 485);
            this.deleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(275, 40);
            this.deleteAll.TabIndex = 33;
            this.deleteAll.Text = "Удалить все данные";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(331, 13);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Фильтр";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(331, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Стаж";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(331, 61);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Профессия";
            // 
            // filterQual
            // 
            this.filterQual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.filterQual.Location = new System.Drawing.Point(423, 61);
            this.filterQual.Margin = new System.Windows.Forms.Padding(2);
            this.filterQual.MaxLength = 20;
            this.filterQual.Name = "filterQual";
            this.filterQual.Size = new System.Drawing.Size(151, 20);
            this.filterQual.TabIndex = 37;
            this.filterQual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.filterQual_MouseMove);
            // 
            // filterExp
            // 
            this.filterExp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.filterExp.Location = new System.Drawing.Point(423, 39);
            this.filterExp.Margin = new System.Windows.Forms.Padding(2);
            this.filterExp.Name = "filterExp";
            this.filterExp.Size = new System.Drawing.Size(151, 20);
            this.filterExp.TabIndex = 38;
            this.filterExp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.filterExp_MouseMove);
            // 
            // filterRecords
            // 
            this.filterRecords.Location = new System.Drawing.Point(334, 94);
            this.filterRecords.Margin = new System.Windows.Forms.Padding(2);
            this.filterRecords.MinimumSize = new System.Drawing.Size(112, 0);
            this.filterRecords.Name = "filterRecords";
            this.filterRecords.Size = new System.Drawing.Size(240, 20);
            this.filterRecords.TabIndex = 39;
            this.filterRecords.Text = "Фильтровать";
            this.filterRecords.UseVisualStyleBackColor = true;
            this.filterRecords.Click += new System.EventHandler(this.filterRecords_Click);
            // 
            // sortItems
            // 
            this.sortItems.Location = new System.Drawing.Point(791, 39);
            this.sortItems.Margin = new System.Windows.Forms.Padding(2);
            this.sortItems.MinimumSize = new System.Drawing.Size(112, 0);
            this.sortItems.Name = "sortItems";
            this.sortItems.Size = new System.Drawing.Size(112, 20);
            this.sortItems.TabIndex = 42;
            this.sortItems.Text = "Сортировать";
            this.sortItems.UseVisualStyleBackColor = true;
            this.sortItems.Click += new System.EventHandler(this.sortItems_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(620, 13);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 15);
            this.label18.TabIndex = 40;
            this.label18.Text = "Сортировка записей";
            // 
            // findItems
            // 
            this.findItems.Location = new System.Drawing.Point(792, 93);
            this.findItems.Margin = new System.Windows.Forms.Padding(2);
            this.findItems.MinimumSize = new System.Drawing.Size(112, 0);
            this.findItems.Name = "findItems";
            this.findItems.Size = new System.Drawing.Size(112, 20);
            this.findItems.TabIndex = 45;
            this.findItems.Text = "Поиск";
            this.findItems.UseVisualStyleBackColor = true;
            this.findItems.Click += new System.EventHandler(this.findItems_Click);
            // 
            // searchFio
            // 
            this.searchFio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchFio.Location = new System.Drawing.Point(623, 94);
            this.searchFio.Margin = new System.Windows.Forms.Padding(2);
            this.searchFio.MaxLength = 20;
            this.searchFio.Name = "searchFio";
            this.searchFio.Size = new System.Drawing.Size(143, 20);
            this.searchFio.TabIndex = 44;
            this.searchFio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.searchFio_MouseMove);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(620, 74);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 15);
            this.label19.TabIndex = 43;
            this.label19.Text = "Поиск по фамилии";
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(150, 107);
            this.yes.Margin = new System.Windows.Forms.Padding(2);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(40, 17);
            this.yes.TabIndex = 48;
            this.yes.TabStop = true;
            this.yes.Text = "Да";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(150, 123);
            this.no.Margin = new System.Windows.Forms.Padding(2);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(44, 17);
            this.no.TabIndex = 49;
            this.no.TabStop = true;
            this.no.Text = "Нет";
            this.no.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(334, 167);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(569, 358);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Стаж";
            this.columnHeader3.Width = 42;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Профессия";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Желание работать по специальности";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Адрес";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Зарплата";
            this.columnHeader7.Width = 65;
            // 
            // chooseSort
            // 
            this.chooseSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseSort.Items.Add("ФИО");
            this.chooseSort.Items.Add("Стаж");
            this.chooseSort.Items.Add("Профессия");
            this.chooseSort.Items.Add("Желание работать по специальности");
            this.chooseSort.Items.Add("Место расположения");
            this.chooseSort.Items.Add("Заработная плата");
            this.chooseSort.Location = new System.Drawing.Point(623, 39);
            this.chooseSort.Margin = new System.Windows.Forms.Padding(2);
            this.chooseSort.MinimumSize = new System.Drawing.Size(131, 0);
            this.chooseSort.Name = "chooseSort";
            this.chooseSort.Size = new System.Drawing.Size(142, 20);
            this.chooseSort.TabIndex = 54;
            this.chooseSort.Text = "Выбрать";
            this.chooseSort.Wrap = true;
            // 
            // resetAll
            // 
            this.resetAll.Location = new System.Drawing.Point(334, 134);
            this.resetAll.Name = "resetAll";
            this.resetAll.Size = new System.Drawing.Size(570, 23);
            this.resetAll.TabIndex = 55;
            this.resetAll.Text = "Сбросить все";
            this.resetAll.UseVisualStyleBackColor = true;
            this.resetAll.Click += new System.EventHandler(this.resetAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 558);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.resetAll);
            this.tabPage1.Controls.Add(this.editRecord);
            this.tabPage1.Controls.Add(this.chooseSort);
            this.tabPage1.Controls.Add(this.fio);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.exp);
            this.tabPage1.Controls.Add(this.no);
            this.tabPage1.Controls.Add(this.adr);
            this.tabPage1.Controls.Add(this.yes);
            this.tabPage1.Controls.Add(this.sal);
            this.tabPage1.Controls.Add(this.findItems);
            this.tabPage1.Controls.Add(this.qual);
            this.tabPage1.Controls.Add(this.searchFio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sortItems);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.filterRecords);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.filterExp);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.filterQual);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.addHuman);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.deleteAll);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.deleteNumber);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.saveToFile);
            this.tabPage1.Controls.Add(this.newValue);
            this.tabPage1.Controls.Add(this.deleteField);
            this.tabPage1.Controls.Add(this.editNumber);
            this.tabPage1.Controls.Add(this.readFromFile);
            this.tabPage1.Controls.Add(this.chooseEdit);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с базой";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resetProfessions);
            this.tabPage2.Controls.Add(this.chooseForProfession);
            this.tabPage2.Controls.Add(this.sortProfessions);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.filterProfessions);
            this.tabPage2.Controls.Add(this.profession);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализ занятости";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 134);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(915, 398);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "№";
            this.columnHeader11.Width = 29;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Специальность";
            this.columnHeader8.Width = 212;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Количество человек";
            this.columnHeader9.Width = 311;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Средний размер желаемой заработной платы";
            this.columnHeader10.Width = 285;
            // 
            // aboutApp
            // 
            this.aboutApp.Location = new System.Drawing.Point(802, 7);
            this.aboutApp.Margin = new System.Windows.Forms.Padding(2);
            this.aboutApp.Name = "aboutApp";
            this.aboutApp.Size = new System.Drawing.Size(112, 20);
            this.aboutApp.TabIndex = 57;
            this.aboutApp.Text = "О приложении";
            this.aboutApp.UseVisualStyleBackColor = true;
            this.aboutApp.Click += new System.EventHandler(this.aboutApp_Click);
            // 
            // resetProfessions
            // 
            this.resetProfessions.Location = new System.Drawing.Point(17, 88);
            this.resetProfessions.Name = "resetProfessions";
            this.resetProfessions.Size = new System.Drawing.Size(431, 23);
            this.resetProfessions.TabIndex = 63;
            this.resetProfessions.Text = "Сбросить все";
            this.resetProfessions.UseVisualStyleBackColor = true;
            this.resetProfessions.Click += new System.EventHandler(this.resetProfessions_Click);
            // 
            // chooseForProfession
            // 
            this.chooseForProfession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseForProfession.Items.Add("Специальность");
            this.chooseForProfession.Items.Add("Количество человек");
            this.chooseForProfession.Items.Add("Средний размер желаемой заработной платы");
            this.chooseForProfession.Location = new System.Drawing.Point(306, 39);
            this.chooseForProfession.Margin = new System.Windows.Forms.Padding(2);
            this.chooseForProfession.MinimumSize = new System.Drawing.Size(131, 0);
            this.chooseForProfession.Name = "chooseForProfession";
            this.chooseForProfession.Size = new System.Drawing.Size(142, 20);
            this.chooseForProfession.TabIndex = 62;
            this.chooseForProfession.Text = "Выбрать";
            this.chooseForProfession.Wrap = true;
            // 
            // sortProfessions
            // 
            this.sortProfessions.Location = new System.Drawing.Point(306, 63);
            this.sortProfessions.Margin = new System.Windows.Forms.Padding(2);
            this.sortProfessions.MinimumSize = new System.Drawing.Size(112, 0);
            this.sortProfessions.Name = "sortProfessions";
            this.sortProfessions.Size = new System.Drawing.Size(142, 20);
            this.sortProfessions.TabIndex = 61;
            this.sortProfessions.Text = "Сортировать";
            this.sortProfessions.UseVisualStyleBackColor = true;
            this.sortProfessions.Click += new System.EventHandler(this.sortProfessions_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(303, 13);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 15);
            this.label20.TabIndex = 60;
            this.label20.Text = "Сортировка записей";
            // 
            // filterProfessions
            // 
            this.filterProfessions.Location = new System.Drawing.Point(17, 63);
            this.filterProfessions.Margin = new System.Windows.Forms.Padding(2);
            this.filterProfessions.MinimumSize = new System.Drawing.Size(112, 0);
            this.filterProfessions.Name = "filterProfessions";
            this.filterProfessions.Size = new System.Drawing.Size(240, 20);
            this.filterProfessions.TabIndex = 59;
            this.filterProfessions.Text = "Фильтровать";
            this.filterProfessions.UseVisualStyleBackColor = true;
            this.filterProfessions.Click += new System.EventHandler(this.filterProfessions_Click);
            // 
            // profession
            // 
            this.profession.ForeColor = System.Drawing.SystemColors.WindowText;
            this.profession.Location = new System.Drawing.Point(106, 39);
            this.profession.Margin = new System.Windows.Forms.Padding(2);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(151, 20);
            this.profession.TabIndex = 58;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 42);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 13);
            this.label21.TabIndex = 57;
            this.label21.Text = "Специальность";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(14, 13);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 15);
            this.label22.TabIndex = 56;
            this.label22.Text = "Фильтр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 589);
            this.Controls.Add(this.aboutApp);
            this.Controls.Add(this.recordsCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Центр занятости";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox adr;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.TextBox qual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox recordsCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addHuman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox newValue;
        private System.Windows.Forms.TextBox editNumber;
        private System.Windows.Forms.DomainUpDown chooseEdit;
        private System.Windows.Forms.Button editRecord;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.Button deleteField;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.TextBox deleteNumber;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox filterQual;
        private System.Windows.Forms.TextBox filterExp;
        private System.Windows.Forms.Button filterRecords;
        private System.Windows.Forms.Button sortItems;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button findItems;
        private System.Windows.Forms.TextBox searchFio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.DomainUpDown chooseSort;
        private System.Windows.Forms.Button resetAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button aboutApp;
        private System.Windows.Forms.Button resetProfessions;
        private System.Windows.Forms.DomainUpDown chooseForProfession;
        private System.Windows.Forms.Button sortProfessions;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button filterProfessions;
        private System.Windows.Forms.TextBox profession;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

