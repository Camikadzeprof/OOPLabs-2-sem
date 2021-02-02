namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.replace = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.words = new System.Windows.Forms.Button();
            this.length = new System.Windows.Forms.Button();
            this.sogl = new System.Windows.Forms.Button();
            this.glas = new System.Windows.Forms.Button();
            this.symbol = new System.Windows.Forms.Button();
            this.sentence = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.collect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(997, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(3, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(997, 32);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(3, 84);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(997, 34);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // replace
            // 
            this.replace.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.replace.Location = new System.Drawing.Point(52, 163);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(108, 41);
            this.replace.TabIndex = 3;
            this.replace.Text = "Замена";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // delete
            // 
            this.delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.delete.Location = new System.Drawing.Point(52, 213);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 41);
            this.delete.TabIndex = 4;
            this.delete.Text = "Удаление";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // words
            // 
            this.words.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.words.Location = new System.Drawing.Point(166, 163);
            this.words.Name = "words";
            this.words.Size = new System.Drawing.Size(108, 41);
            this.words.TabIndex = 5;
            this.words.Text = "Слова";
            this.words.UseVisualStyleBackColor = true;
            this.words.Click += new System.EventHandler(this.words_Click);
            // 
            // length
            // 
            this.length.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.length.Location = new System.Drawing.Point(280, 163);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(108, 41);
            this.length.TabIndex = 6;
            this.length.Text = "Длина";
            this.length.UseVisualStyleBackColor = true;
            this.length.Click += new System.EventHandler(this.length_Click);
            // 
            // sogl
            // 
            this.sogl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sogl.Location = new System.Drawing.Point(166, 210);
            this.sogl.Name = "sogl";
            this.sogl.Size = new System.Drawing.Size(108, 41);
            this.sogl.TabIndex = 7;
            this.sogl.Text = "Согласные";
            this.sogl.UseVisualStyleBackColor = true;
            this.sogl.Click += new System.EventHandler(this.sogl_Click);
            // 
            // glas
            // 
            this.glas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.glas.Location = new System.Drawing.Point(280, 210);
            this.glas.Name = "glas";
            this.glas.Size = new System.Drawing.Size(108, 41);
            this.glas.TabIndex = 8;
            this.glas.Text = "Гласные";
            this.glas.UseVisualStyleBackColor = true;
            this.glas.Click += new System.EventHandler(this.glas_Click);
            // 
            // symbol
            // 
            this.symbol.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.symbol.Location = new System.Drawing.Point(52, 260);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(108, 41);
            this.symbol.TabIndex = 9;
            this.symbol.Text = "Символ";
            this.symbol.UseVisualStyleBackColor = true;
            this.symbol.Click += new System.EventHandler(this.symbol_Click);
            // 
            // sentence
            // 
            this.sentence.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sentence.Location = new System.Drawing.Point(166, 260);
            this.sentence.Name = "sentence";
            this.sentence.Size = new System.Drawing.Size(108, 41);
            this.sentence.TabIndex = 10;
            this.sentence.Text = "Предложения";
            this.sentence.UseVisualStyleBackColor = true;
            this.sentence.Click += new System.EventHandler(this.sentence_Click);
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(394, 163);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 138);
            this.clear.TabIndex = 11;
            this.clear.Text = "Очистка";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // enter
            // 
            this.enter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.enter.Location = new System.Drawing.Point(280, 260);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(108, 41);
            this.enter.TabIndex = 12;
            this.enter.Text = "Ввод";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(475, 163);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(525, 138);
            this.textBox4.TabIndex = 13;
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(475, 337);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(525, 95);
            this.exit.TabIndex = 14;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // collect
            // 
            this.collect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.collect.Location = new System.Drawing.Point(52, 337);
            this.collect.Name = "collect";
            this.collect.Size = new System.Drawing.Size(417, 95);
            this.collect.TabIndex = 15;
            this.collect.Text = "Перейти к коллекциям";
            this.collect.UseVisualStyleBackColor = true;
            this.collect.Click += new System.EventHandler(this.collect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(1012, 477);
            this.Controls.Add(this.collect);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.sentence);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.glas);
            this.Controls.Add(this.sogl);
            this.Controls.Add(this.length);
            this.Controls.Add(this.words);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button words;
        private System.Windows.Forms.Button length;
        private System.Windows.Forms.Button sogl;
        private System.Windows.Forms.Button glas;
        private System.Windows.Forms.Button symbol;
        private System.Windows.Forms.Button sentence;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button collect;
    }
}

