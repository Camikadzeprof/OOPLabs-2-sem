namespace WindowsForms3
{
    partial class Search
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
            this.regular = new System.Windows.Forms.TextBox();
            this.extended = new System.Windows.Forms.CheckBox();
            this.parameters = new System.Windows.Forms.GroupBox();
            this.kolk = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeofsort = new System.Windows.Forms.DomainUpDown();
            this.searching = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регулярное выражение";
            // 
            // regular
            // 
            this.regular.Location = new System.Drawing.Point(13, 23);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(163, 22);
            this.regular.TabIndex = 1;
            // 
            // extended
            // 
            this.extended.AutoSize = true;
            this.extended.Location = new System.Drawing.Point(13, 52);
            this.extended.Name = "extended";
            this.extended.Size = new System.Drawing.Size(123, 21);
            this.extended.TabIndex = 2;
            this.extended.Text = "Расширенный";
            this.extended.UseVisualStyleBackColor = true;
            this.extended.CheckedChanged += new System.EventHandler(this.extended_CheckedChanged);
            // 
            // parameters
            // 
            this.parameters.Controls.Add(this.kolk);
            this.parameters.Controls.Add(this.label4);
            this.parameters.Controls.Add(this.year);
            this.parameters.Controls.Add(this.label3);
            this.parameters.Controls.Add(this.city);
            this.parameters.Controls.Add(this.label2);
            this.parameters.Location = new System.Drawing.Point(13, 80);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(219, 115);
            this.parameters.TabIndex = 3;
            this.parameters.TabStop = false;
            this.parameters.Text = "Параметры";
            this.parameters.Visible = false;
            // 
            // kolk
            // 
            this.kolk.Location = new System.Drawing.Point(113, 86);
            this.kolk.Name = "kolk";
            this.kolk.Size = new System.Drawing.Size(100, 22);
            this.kolk.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кол-во комнат";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(112, 52);
            this.year.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(101, 22);
            this.year.TabIndex = 3;
            this.year.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(113, 21);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Город";
            // 
            // typeofsort
            // 
            this.typeofsort.Items.Add("По площади");
            this.typeofsort.Items.Add("По цене");
            this.typeofsort.Location = new System.Drawing.Point(13, 213);
            this.typeofsort.Name = "typeofsort";
            this.typeofsort.Size = new System.Drawing.Size(120, 22);
            this.typeofsort.TabIndex = 4;
            this.typeofsort.Text = "По площади";
            // 
            // searching
            // 
            this.searching.Location = new System.Drawing.Point(51, 245);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(125, 23);
            this.searching.TabIndex = 5;
            this.searching.Text = "Поиск";
            this.searching.UseVisualStyleBackColor = true;
            this.searching.Click += new System.EventHandler(this.searching_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Результаты поиска";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(254, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 244);
            this.listBox1.TabIndex = 7;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 280);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searching);
            this.Controls.Add(this.typeofsort);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.extended);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.parameters.ResumeLayout(false);
            this.parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regular;
        private System.Windows.Forms.CheckBox extended;
        private System.Windows.Forms.GroupBox parameters;
        private System.Windows.Forms.NumericUpDown kolk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown typeofsort;
        private System.Windows.Forms.Button searching;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}