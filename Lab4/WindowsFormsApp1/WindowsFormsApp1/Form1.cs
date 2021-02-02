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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            if(textBox3.Text!="")
            {
                if(textBox1.Text!="")
                {
                    textBox4.Clear();
                    textBox4.Text = textBox3.Text;
                    textBox4.Text = textBox4.Text.Replace(textBox2.Text, textBox1.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Введите строку для замены и нажмите кнопку Замена");
                }
            }
            else
            {
                if (textBox4.Text != "")
                {
                    textBox2.Text = textBox4.Text;
                    textBox4.Clear();
                    if (textBox2.Text != "")
                    {
                        textBox4.Text = textBox3.Text;
                        textBox4.Text = textBox4.Text.Replace(textBox2.Text, textBox1.Text);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите заменяемую подстроку и нажмите Ввод, затем повторно нажмите кнопку Замена");
                    }
                }
                else
                {
                    MessageBox.Show("Введите заменяемую подстроку и нажмите Ввод, затем повторно нажмите кнопку Замена");
                }
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                if(textBox2.Text=="")
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Clear();
                }
                else
                {
                    if(textBox3.Text=="")
                    {
                        textBox3.Text = textBox2.Text;
                        textBox2.Text = textBox1.Text;
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Все данные уже введены");
                    }
                }
            }
            if (textBox4.Text != "") textBox4.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    if (textBox2.Text != "")
                    {
                        if (textBox1.Text != "")
                        {
                            textBox4.Text = textBox2.Text;
                            textBox4.Text = textBox4.Text.Replace(textBox1.Text, "");
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Введите удаляемую подстроку");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите исходную строку");
                    }
                }
                else
                {
                    MessageBox.Show("Введено слишком много данных");
                }
            }
            else
            {
                textBox2.Text = textBox4.Text;
                textBox4.Clear();
                if(textBox3.Text=="")
                {
                    if (textBox2.Text != "")
                    {
                        if (textBox1.Text != "")
                        {
                            textBox4.Text = textBox2.Text;
                            textBox4.Text = textBox4.Text.Replace(textBox1.Text, "");
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Введите удаляемую подстроку");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите исходную строку");
                    }
                }
                else
                {
                    MessageBox.Show("Введено слишком много данных");
                }
            }
        }

        private void length_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") && (textBox3.Text == ""))
            {
                if (textBox1.Text != "")
                {
                    MessageBox.Show($"Дллина строки: {textBox1.Text.Length} символов");
                }
                else
                {
                    if (textBox4.Text != "")
                    {
                        MessageBox.Show($"Длина строки: {textBox4.Text.Length} символов");
                        textBox1.Text = textBox4.Text;
                        textBox4.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите строку");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введено слишком много данных");
            }
        }

        private void symbol_Click(object sender, EventArgs e)
        {
            if(textBox4.Text=="")
            {
                if(textBox3.Text=="")
                {
                    if(textBox2.Text!="")
                    {
                        if(textBox1.Text!="")
                        {
                            if(Convert.ToInt32(textBox1.Text)<=textBox2.Text.Length)
                            {
                                textBox4.Text += textBox2.Text[Convert.ToInt32(textBox1.Text) - 1];
                                textBox1.Clear();
                                textBox2.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Символа с данным индексом не существует");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите индекс символа");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите исходную строку");
                    }
                }
                else
                {
                    MessageBox.Show("Введено слишком много данных");
                }
            }
            else
            {
                textBox2.Text = textBox4.Text;
                textBox4.Clear();
                if (textBox3.Text == "")
                {
                    if (textBox2.Text != "")
                    {
                        if (textBox1.Text != "")
                        {
                            if (Convert.ToInt32(textBox1.Text) <= textBox2.Text.Length)
                            {
                                textBox4.Text += textBox2.Text[Convert.ToInt32(textBox1.Text) - 1];
                                textBox1.Clear();
                                textBox2.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Символа с данным индексом не существует");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите индекс символа");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите исходную строку");
                    }
                }
                else
                {
                    MessageBox.Show("Введено слишком много данных");
                }
            }
        }

        private void collect_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sogl_Click(object sender, EventArgs e)
        {
            int count = 0;
            char[] sogl = new char[] { 'A', 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'd', 't', 'v', 'w', 'x', 'y', 'z', 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            if ((textBox4.Text == "") || (textBox1.Text != ""))
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    for (int j = 0; j < sogl.Length; j++)
                    {
                        if (textBox1.Text[i] == sogl[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    for (int j = 0; j < sogl.Length; j++)
                    {
                        if (textBox4.Text[i] == sogl[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                textBox1.Text = textBox4.Text;
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            MessageBox.Show($"В строке {count} согласных");
        }

        private void glas_Click(object sender, EventArgs e)
        {
            int count = 0;
            char[] glas = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я', 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            if ((textBox4.Text == "") || (textBox1.Text != ""))
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    for (int j = 0; j < glas.Length; j++)
                    {
                        if (textBox1.Text[i] == glas[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                for(int i=0;i<textBox4.Text.Length;i++)
                {
                    for(int j=0;j<glas.Length;j++)
                    {
                        if (textBox4.Text[i] == glas[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                textBox1.Text = textBox4.Text;
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            MessageBox.Show($"В строке {count} гласных");
        }

        private void words_Click(object sender, EventArgs e)
        {
            int count = 0;
            if ((textBox4.Text == "") || (textBox1.Text != ""))
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if ((textBox1.Text[i] == ' ') || (textBox1.Text[i] == '.') || (textBox1.Text[i] == ',') || (textBox1.Text[i] == '!') || (textBox1.Text[i] == '?') || (textBox1.Text[i] == ';') || (textBox1.Text[i] == ':') || (textBox1.Text[i] == '"') || (textBox1.Text[i] == '-') || (textBox1.Text[i] == '\'') || (i == textBox1.Text.Length - 1))
                    {
                        count++;
                    }
                }
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if ((textBox4.Text[i] == ' ') || (textBox4.Text[i] == '.') || (textBox4.Text[i] == ',') || (textBox4.Text[i] == '!') || (textBox4.Text[i] == '?') || (textBox4.Text[i] == ';') || (textBox4.Text[i] == ':') || (textBox4.Text[i] == '"') || (textBox4.Text[i] == '-') || (textBox4.Text[i] == '\'') || (i == textBox4.Text.Length - 1))
                    {
                        count++;
                    }
                }
                textBox1.Text = textBox4.Text;
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            MessageBox.Show($"В строке {count} слов");
        }

        private void sentence_Click(object sender, EventArgs e)
        {
            int count = 0;
            if ((textBox4.Text == "") || (textBox1.Text != ""))
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if ((textBox1.Text[i] == '.') || (textBox1.Text[i] == '!') || (textBox1.Text[i] == '?') || (i == textBox1.Text.Length - 1))
                    {
                        count++;
                    }
                }
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if ((textBox4.Text[i] == '.') || (textBox4.Text[i] == '!') || (textBox4.Text[i] == '?') || (i == textBox4.Text.Length - 1))
                    {
                        count++;
                    }
                }
                textBox1.Text = textBox4.Text;
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            MessageBox.Show($"В строке {count} предложений");
        }
    }
}