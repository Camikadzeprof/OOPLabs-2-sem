namespace WindowsFormsApp1
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generation = new System.Windows.Forms.Button();
            this.sortVozr = new System.Windows.Forms.Button();
            this.sortUbiv = new System.Windows.Forms.Button();
            this.zapr1 = new System.Windows.Forms.Button();
            this.zapr2 = new System.Windows.Forms.Button();
            this.zapr3 = new System.Windows.Forms.Button();
            this.prostoKol = new System.Windows.Forms.ListBox();
            this.sortKol = new System.Windows.Forms.ListBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(478, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер коллекции";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // generation
            // 
            this.generation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generation.Location = new System.Drawing.Point(359, 135);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(378, 74);
            this.generation.TabIndex = 2;
            this.generation.Text = "Сгенерировать коллекцию";
            this.generation.UseVisualStyleBackColor = true;
            this.generation.Click += new System.EventHandler(this.generation_Click);
            // 
            // sortVozr
            // 
            this.sortVozr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortVozr.Location = new System.Drawing.Point(50, 135);
            this.sortVozr.Name = "sortVozr";
            this.sortVozr.Size = new System.Drawing.Size(203, 74);
            this.sortVozr.TabIndex = 3;
            this.sortVozr.Text = "Сортировать по возрастанию";
            this.sortVozr.UseVisualStyleBackColor = true;
            this.sortVozr.Click += new System.EventHandler(this.sortVozr_Click);
            // 
            // sortUbiv
            // 
            this.sortUbiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortUbiv.Location = new System.Drawing.Point(828, 135);
            this.sortUbiv.Name = "sortUbiv";
            this.sortUbiv.Size = new System.Drawing.Size(203, 74);
            this.sortUbiv.TabIndex = 4;
            this.sortUbiv.Text = "Сортировать по убыванию";
            this.sortUbiv.UseVisualStyleBackColor = true;
            this.sortUbiv.Click += new System.EventHandler(this.sortUbiv_Click);
            // 
            // zapr1
            // 
            this.zapr1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zapr1.Location = new System.Drawing.Point(208, 250);
            this.zapr1.Name = "zapr1";
            this.zapr1.Size = new System.Drawing.Size(97, 46);
            this.zapr1.TabIndex = 5;
            this.zapr1.Text = "Запрос 1";
            this.zapr1.UseVisualStyleBackColor = true;
            this.zapr1.Click += new System.EventHandler(this.zapr1_Click);
            // 
            // zapr2
            // 
            this.zapr2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zapr2.Location = new System.Drawing.Point(471, 250);
            this.zapr2.Name = "zapr2";
            this.zapr2.Size = new System.Drawing.Size(97, 46);
            this.zapr2.TabIndex = 6;
            this.zapr2.Text = "Запрос 2";
            this.zapr2.UseVisualStyleBackColor = true;
            this.zapr2.Click += new System.EventHandler(this.zapr2_Click);
            // 
            // zapr3
            // 
            this.zapr3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zapr3.Location = new System.Drawing.Point(742, 250);
            this.zapr3.Name = "zapr3";
            this.zapr3.Size = new System.Drawing.Size(97, 46);
            this.zapr3.TabIndex = 7;
            this.zapr3.Text = "Запрос 3";
            this.zapr3.UseVisualStyleBackColor = true;
            this.zapr3.Click += new System.EventHandler(this.zapr3_Click);
            // 
            // prostoKol
            // 
            this.prostoKol.FormattingEnabled = true;
            this.prostoKol.ItemHeight = 16;
            this.prostoKol.Location = new System.Drawing.Point(68, 336);
            this.prostoKol.Name = "prostoKol";
            this.prostoKol.Size = new System.Drawing.Size(163, 132);
            this.prostoKol.TabIndex = 8;
            // 
            // sortKol
            // 
            this.sortKol.FormattingEnabled = true;
            this.sortKol.ItemHeight = 16;
            this.sortKol.Location = new System.Drawing.Point(803, 336);
            this.sortKol.Name = "sortKol";
            this.sortKol.Size = new System.Drawing.Size(163, 132);
            this.sortKol.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Location = new System.Drawing.Point(409, 348);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(227, 50);
            this.exit.TabIndex = 11;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 503);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sortKol);
            this.Controls.Add(this.prostoKol);
            this.Controls.Add(this.zapr3);
            this.Controls.Add(this.zapr2);
            this.Controls.Add(this.zapr1);
            this.Controls.Add(this.sortUbiv);
            this.Controls.Add(this.sortVozr);
            this.Controls.Add(this.generation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generation;
        private System.Windows.Forms.Button sortVozr;
        private System.Windows.Forms.Button sortUbiv;
        private System.Windows.Forms.Button zapr1;
        private System.Windows.Forms.Button zapr2;
        private System.Windows.Forms.Button zapr3;
        private System.Windows.Forms.ListBox prostoKol;
        private System.Windows.Forms.ListBox sortKol;
        private System.Windows.Forms.Button exit;
    }
}