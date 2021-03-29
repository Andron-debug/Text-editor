using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            b = new Button[26];
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
    }
}
