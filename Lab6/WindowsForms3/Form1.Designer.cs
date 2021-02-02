namespace WindowsForms3
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
            this.label1 = new System.Windows.Forms.Label();
            this.kolk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.meters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.floor = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.mattype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateofbld = new System.Windows.Forms.DateTimePicker();
            this.kitchen = new System.Windows.Forms.CheckBox();
            this.toilet = new System.Windows.Forms.CheckBox();
            this.bath = new System.Windows.Forms.CheckBox();
            this.balc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kolWindows = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.soln = new System.Windows.Forms.RadioButton();
            this.nesoln = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.house = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.площадьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolopen = new System.Windows.Forms.ToolStripButton();
            this.toolsave = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.datetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.kolobj = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lastoperation = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kolk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество комнат";
            // 
            // kolk
            // 
            this.kolk.Location = new System.Drawing.Point(11, 85);
            this.kolk.Name = "kolk";
            this.kolk.Size = new System.Drawing.Size(120, 22);
            this.kolk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Метраж";
            // 
            // meters
            // 
            this.meters.Location = new System.Drawing.Point(11, 135);
            this.meters.Name = "meters";
            this.meters.Size = new System.Drawing.Size(120, 22);
            this.meters.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Этаж";
            // 
            // floor
            // 
            this.floor.Location = new System.Drawing.Point(11, 185);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(250, 56);
            this.floor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип материала";
            // 
            // mattype
            // 
            this.mattype.FormattingEnabled = true;
            this.mattype.Items.AddRange(new object[] {
            "Дерево",
            "Кирпич",
            "Панели",
            "Блоки"});
            this.mattype.Location = new System.Drawing.Point(11, 252);
            this.mattype.Name = "mattype";
            this.mattype.Size = new System.Drawing.Size(121, 24);
            this.mattype.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // dateofbld
            // 
            this.dateofbld.Location = new System.Drawing.Point(11, 304);
            this.dateofbld.Name = "dateofbld";
            this.dateofbld.Size = new System.Drawing.Size(200, 22);
            this.dateofbld.TabIndex = 9;
            // 
            // kitchen
            // 
            this.kitchen.AutoSize = true;
            this.kitchen.Location = new System.Drawing.Point(11, 333);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(68, 21);
            this.kitchen.TabIndex = 10;
            this.kitchen.Text = "Кухня";
            this.kitchen.UseVisualStyleBackColor = true;
            // 
            // toilet
            // 
            this.toilet.AutoSize = true;
            this.toilet.Location = new System.Drawing.Point(86, 333);
            this.toilet.Name = "toilet";
            this.toilet.Size = new System.Drawing.Size(77, 21);
            this.toilet.TabIndex = 11;
            this.toilet.Text = "Туалет";
            this.toilet.UseVisualStyleBackColor = true;
            // 
            // bath
            // 
            this.bath.AutoSize = true;
            this.bath.Location = new System.Drawing.Point(11, 361);
            this.bath.Name = "bath";
            this.bath.Size = new System.Drawing.Size(79, 21);
            this.bath.TabIndex = 12;
            this.bath.Text = "Ванная";
            this.bath.UseVisualStyleBackColor = true;
            // 
            // balc
            // 
            this.balc.AutoSize = true;
            this.balc.Location = new System.Drawing.Point(86, 361);
            this.balc.Name = "balc";
            this.balc.Size = new System.Drawing.Size(78, 21);
            this.balc.TabIndex = 13;
            this.balc.Text = "Балкон";
            this.balc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количество окон";
            // 
            // kolWindows
            // 
            this.kolWindows.Location = new System.Drawing.Point(11, 406);
            this.kolWindows.Name = "kolWindows";
            this.kolWindows.Size = new System.Drawing.Size(120, 22);
            this.kolWindows.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Сторона";
            // 
            // soln
            // 
            this.soln.AutoSize = true;
            this.soln.Location = new System.Drawing.Point(199, 406);
            this.soln.Name = "soln";
            this.soln.Size = new System.Drawing.Size(102, 21);
            this.soln.TabIndex = 17;
            this.soln.TabStop = true;
            this.soln.Text = "Солнечная";
            this.soln.UseVisualStyleBackColor = true;
            // 
            // nesoln
            // 
            this.nesoln.AutoSize = true;
            this.nesoln.Location = new System.Drawing.Point(325, 406);
            this.nesoln.Name = "nesoln";
            this.nesoln.Size = new System.Drawing.Size(122, 21);
            this.nesoln.TabIndex = 18;
            this.nesoln.TabStop = true;
            this.nesoln.Text = "Не солнечная";
            this.nesoln.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Страна";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(495, 84);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 22);
            this.country.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Город";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(495, 135);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Улица";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(495, 185);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 22);
            this.street.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(510, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Дом";
            // 
            // house
            // 
            this.house.Location = new System.Drawing.Point(495, 234);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(100, 22);
            this.house.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(513, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Квартира";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(495, 283);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 22);
            this.number.TabIndex = 28;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(11, 435);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(121, 23);
            this.add.TabIndex = 30;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(11, 465);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 23);
            this.save.TabIndex = 31;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(11, 495);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(120, 23);
            this.open.TabIndex = 32;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ценаToolStripMenuItem,
            this.площадьToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по";
            // 
            // ценаToolStripMenuItem
            // 
            this.ценаToolStripMenuItem.Name = "ценаToolStripMenuItem";
            this.ценаToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.ценаToolStripMenuItem.Text = "Цена";
            this.ценаToolStripMenuItem.Click += new System.EventHandler(this.ценаToolStripMenuItem_Click);
            // 
            // площадьToolStripMenuItem
            // 
            this.площадьToolStripMenuItem.Name = "площадьToolStripMenuItem";
            this.площадьToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.площадьToolStripMenuItem.Text = "Площадь";
            this.площадьToolStripMenuItem.Click += new System.EventHandler(this.площадьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolopen,
            this.toolsave,
            this.exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolopen
            // 
            this.toolopen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolopen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolopen.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolopen.Name = "toolopen";
            this.toolopen.Size = new System.Drawing.Size(71, 24);
            this.toolopen.Text = "Открыть";
            this.toolopen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolopen.Click += new System.EventHandler(this.toolopen_Click);
            // 
            // toolsave
            // 
            this.toolsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsave.Image = ((System.Drawing.Image)(resources.GetObject("toolsave.Image")));
            this.toolsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsave.Name = "toolsave";
            this.toolsave.Size = new System.Drawing.Size(87, 24);
            this.toolsave.Text = "Сохранить";
            this.toolsave.Click += new System.EventHandler(this.toolsave_Click);
            // 
            // exit
            // 
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(57, 24);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datetime,
            this.kolobj,
            this.lastoperation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(925, 25);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // datetime
            // 
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(102, 20);
            this.datetime.Text = "Дата и время";
            this.datetime.Click += new System.EventHandler(this.datetime_Click);
            // 
            // kolobj
            // 
            this.kolobj.Name = "kolobj";
            this.kolobj.Size = new System.Drawing.Size(159, 20);
            this.kolobj.Text = "Количество объектов";
            this.kolobj.Click += new System.EventHandler(this.kolobj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(623, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 436);
            this.listBox1.TabIndex = 29;
            // 
            // lastoperation
            // 
            this.lastoperation.Name = "lastoperation";
            this.lastoperation.Size = new System.Drawing.Size(158, 20);
            this.lastoperation.Text = "Последняя операция";
            this.lastoperation.Click += new System.EventHandler(this.lastoperation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.house);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.street);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nesoln);
            this.Controls.Add(this.soln);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kolWindows);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.balc);
            this.Controls.Add(this.bath);
            this.Controls.Add(this.toilet);
            this.Controls.Add(this.kitchen);
            this.Controls.Add(this.dateofbld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mattype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kolk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kolk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown kolk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar floor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mattype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateofbld;
        private System.Windows.Forms.CheckBox kitchen;
        private System.Windows.Forms.CheckBox toilet;
        private System.Windows.Forms.CheckBox bath;
        private System.Windows.Forms.CheckBox balc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kolWindows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton soln;
        private System.Windows.Forms.RadioButton nesoln;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox house;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolopen;
        private System.Windows.Forms.ToolStripButton toolsave;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel datetime;
        private System.Windows.Forms.ToolStripStatusLabel kolobj;
        private System.Windows.Forms.ToolStripMenuItem ценаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem площадьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripStatusLabel lastoperation;
    }
}

