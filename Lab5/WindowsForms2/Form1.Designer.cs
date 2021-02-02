namespace WindowsForms2
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
            this.kolk = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meters = new System.Windows.Forms.TextBox();
            this.floor = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.mattype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateofbld = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.kitchen = new System.Windows.Forms.CheckBox();
            this.toilet = new System.Windows.Forms.CheckBox();
            this.bath = new System.Windows.Forms.CheckBox();
            this.balc = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.house = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kolWindows = new System.Windows.Forms.TextBox();
            this.soln = new System.Windows.Forms.RadioButton();
            this.nesoln = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kolk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // kolk
            // 
            this.kolk.Location = new System.Drawing.Point(12, 40);
            this.kolk.Name = "kolk";
            this.kolk.Size = new System.Drawing.Size(120, 22);
            this.kolk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество комнат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Метраж";
            // 
            // meters
            // 
            this.meters.Location = new System.Drawing.Point(15, 90);
            this.meters.Name = "meters";
            this.meters.Size = new System.Drawing.Size(117, 22);
            this.meters.TabIndex = 3;
            // 
            // floor
            // 
            this.floor.Location = new System.Drawing.Point(12, 141);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(272, 56);
            this.floor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Этаж";
            // 
            // mattype
            // 
            this.mattype.FormattingEnabled = true;
            this.mattype.Items.AddRange(new object[] {
            "Дерево",
            "Панели",
            "Кирпич",
            "Блоки"});
            this.mattype.Location = new System.Drawing.Point(15, 203);
            this.mattype.Name = "mattype";
            this.mattype.Size = new System.Drawing.Size(121, 24);
            this.mattype.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип материала";
            // 
            // dateofbld
            // 
            this.dateofbld.Location = new System.Drawing.Point(12, 260);
            this.dateofbld.Name = "dateofbld";
            this.dateofbld.Size = new System.Drawing.Size(200, 22);
            this.dateofbld.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата постройки";
            // 
            // kitchen
            // 
            this.kitchen.AutoSize = true;
            this.kitchen.Location = new System.Drawing.Point(13, 310);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(68, 21);
            this.kitchen.TabIndex = 10;
            this.kitchen.Text = "Кухня";
            this.kitchen.UseVisualStyleBackColor = true;
            // 
            // toilet
            // 
            this.toilet.AutoSize = true;
            this.toilet.Location = new System.Drawing.Point(87, 310);
            this.toilet.Name = "toilet";
            this.toilet.Size = new System.Drawing.Size(77, 21);
            this.toilet.TabIndex = 11;
            this.toilet.Text = "Туалет";
            this.toilet.UseVisualStyleBackColor = true;
            // 
            // bath
            // 
            this.bath.AutoSize = true;
            this.bath.Location = new System.Drawing.Point(12, 338);
            this.bath.Name = "bath";
            this.bath.Size = new System.Drawing.Size(79, 21);
            this.bath.TabIndex = 12;
            this.bath.Text = "Ванная";
            this.bath.UseVisualStyleBackColor = true;
            // 
            // balc
            // 
            this.balc.AutoSize = true;
            this.balc.Location = new System.Drawing.Point(87, 338);
            this.balc.Name = "balc";
            this.balc.Size = new System.Drawing.Size(78, 21);
            this.balc.TabIndex = 13;
            this.balc.Text = "Балкон";
            this.balc.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 410);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(138, 23);
            this.add.TabIndex = 14;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 439);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(138, 23);
            this.save.TabIndex = 15;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 468);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(138, 23);
            this.open.TabIndex = 16;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Страна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Улица";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Дом";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Номер квартиры";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(316, 40);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 22);
            this.country.TabIndex = 22;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(316, 93);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 23;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(316, 138);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 22);
            this.street.TabIndex = 24;
            // 
            // house
            // 
            this.house.Location = new System.Drawing.Point(316, 183);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(100, 22);
            this.house.TabIndex = 25;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(316, 228);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 22);
            this.number.TabIndex = 26;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(461, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 420);
            this.listBox1.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Количество окон";
            // 
            // kolWindows
            // 
            this.kolWindows.Location = new System.Drawing.Point(14, 383);
            this.kolWindows.Name = "kolWindows";
            this.kolWindows.Size = new System.Drawing.Size(100, 22);
            this.kolWindows.TabIndex = 29;
            // 
            // soln
            // 
            this.soln.AutoSize = true;
            this.soln.Location = new System.Drawing.Point(174, 383);
            this.soln.Name = "soln";
            this.soln.Size = new System.Drawing.Size(102, 21);
            this.soln.TabIndex = 30;
            this.soln.TabStop = true;
            this.soln.Text = "Солнечная";
            this.soln.UseVisualStyleBackColor = true;
            // 
            // nesoln
            // 
            this.nesoln.AutoSize = true;
            this.nesoln.Location = new System.Drawing.Point(307, 384);
            this.nesoln.Name = "nesoln";
            this.nesoln.Size = new System.Drawing.Size(122, 21);
            this.nesoln.TabIndex = 31;
            this.nesoln.TabStop = true;
            this.nesoln.Text = "Не солнечная";
            this.nesoln.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Сторона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nesoln);
            this.Controls.Add(this.soln);
            this.Controls.Add(this.kolWindows);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.house);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.balc);
            this.Controls.Add(this.bath);
            this.Controls.Add(this.toilet);
            this.Controls.Add(this.kitchen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateofbld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mattype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.meters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kolk);
            this.Name = "Form1";
            this.Text = "Квартира";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kolk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown kolk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meters;
        private System.Windows.Forms.TrackBar floor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mattype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateofbld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox kitchen;
        private System.Windows.Forms.CheckBox toilet;
        private System.Windows.Forms.CheckBox bath;
        private System.Windows.Forms.CheckBox balc;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox house;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox kolWindows;
        private System.Windows.Forms.RadioButton soln;
        private System.Windows.Forms.RadioButton nesoln;
        private System.Windows.Forms.Label label12;
    }
}

