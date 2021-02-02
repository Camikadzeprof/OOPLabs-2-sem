using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public delegate bool Comparator(object first, object second);
        private Comparator algo;

        public void Sort()
        {
            for (int i = 0; i < prostoKol.Items.Count; ++i)
                for (int j = i + 1; j < prostoKol.Items.Count; ++j)
                {
                    if (algo(prostoKol.Items[i], prostoKol.Items[j]))
                    {
                        object temp = prostoKol.Items[i];
                        prostoKol.Items[i] = prostoKol.Items[j];
                        prostoKol.Items[j] = temp;
                    }
                }
        }



        private void generation_Click(object sender, EventArgs e)  
        {
            if (Int32.TryParse(textBox1.Text, out int count))
            {
                prostoKol.Items.Clear();
                Random random = new Random();
                for (int i = 0; i < count; ++i)
                    prostoKol.Items.Add(random.Next(100));
            }
        }



        private void sortVozr_Click(object sender, EventArgs e)  
        {
            algo = (object first, object second) => (Int32)first > (Int32)second;
            Sort();
        }

        private void sortUbiv_Click(object sender, EventArgs e)  
        {
            algo = (object first, object second) => (Int32)first < (Int32)second;
            Sort();
        }






        private void zapr1_Click(object sender, EventArgs e)
        {
            int result = prostoKol.Items.Cast<int>().Min();
            sortKol.Items.Clear();
            sortKol.Items.Add(result);
        }

        private void zapr2_Click(object sender, EventArgs e)  //ЗАПРОС 2 (30 < x < e60
        {
            IEnumerable<int> result = prostoKol.Items.Cast<int>().Where(x => x >= 30 && x <= 60).OrderBy(x => x);
            sortKol.Items.Clear();
            foreach (int item in result)
                sortKol.Items.Add(item);
        }

        private void zapr3_Click(object sender, EventArgs e)
        {
            int result = prostoKol.Items.Cast<int>().Max();
            sortKol.Items.Clear();
            sortKol.Items.Add(result);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();       
        }
    }
}
