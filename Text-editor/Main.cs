using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_editor
{
    public partial class Clean_up : Form
    {
        public Clean_up()
        {
            InitializeComponent();
        }
        Button[] b; 
        private void Main_Load(object sender, EventArgs e)
        {
            char[] ch = { ' ', '?', '*', '!' };
            b = new Button[26+ch.Length];
            this.Width = b.Length * 40 + 30;
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Button();
                b[i].Width= 40;
                b[i].Height = 40;
                b[i].Top = 100;
                b[i].Left = i * b[i].Height + 5;
                b[i].Click += button_clicked;
                b[i].Text = Convert.ToString(Convert.ToChar(i+65));
                b[i].Name = "Button" + Convert.ToChar(i + 65);
                Controls.Add(b[i]);
            }
            for (int i = 0; i < ch.Length; i++)
            {
                b[i + 26].Text = Convert.ToString(ch[i]);
            }
            
        }
        private void button_clicked(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            textBox_str.Text += c.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_str.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                StreamWriter sr = new StreamWriter("My_str.txt", checkBox1.Checked);
                sr.WriteLine(textBox_str.Text);
                sr.Close();
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int si = comboBox1.SelectedIndex;
            string new_str = "";
            string last_str = textBox_str.Text;
            switch (si)
            {
                case 0: // Удалить "*"
                    for (int i = 0; i < last_str.Length; i++)
                    {
                        if (last_str[i] != Convert.ToChar("*")) new_str += last_str[i];
                    }
                    textBox_str.Text = new_str;
                    break;
                case 1: // Заменить "*" на "+"
                    for (int i = 0; i < last_str.Length; i++)
                    {
                        if (last_str[i] != Convert.ToChar("*")) new_str += last_str[i];
                        else new_str += "+";
                    }
                    textBox_str.Text = new_str;
                    break;
                case 2: // заменить IVT на ISAY
                    for (int i = 0; i <last_str.Length; i++)
                    {
                        if ((last_str[i] == 'I')&&(last_str[i+1] == 'V')&&(last_str[i+2] == 'T'))
                        {
                            new_str += "IVAY";
                            i += 2;
                        }
                        else
                        {
                            new_str += last_str[i];
                        }
                        
                    }
                    textBox_str.Text = new_str;
                    break;
                case 3: //  Все в нижний регистр
                    for (int i = 0; i < last_str.Length; i++)
                    {
                        if ((Convert.ToInt32(last_str[i]) >= 65) && (Convert.ToInt32(last_str[i]) <= 90)) new_str += Convert.ToString(Convert.ToChar(last_str[i] + Convert.ToChar(32)));
                        else new_str += last_str[i];
                        textBox_str.Text = new_str;
                    }
                    break;
                case 4: //Определить количество слов
                    int words = 0;
                    if (last_str != "") words++;
                    for (int i = 0; i < last_str.Length; i++)
                    {
                        if (last_str[i] == ' ') words++;
                    }
                    textBox_str.Text = "Количество слов: " + words;
                        break;
                default:
                    MessageBox.Show("Выберете режим");
                    break;
            }
        }
    }
}
