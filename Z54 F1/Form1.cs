using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z54_F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ElementOfRICHWasChanched(object sender, EventArgs e)
        {
            textBox4.Text = $"РИЧ № {textBox7.Text} от {textBox6.Text} до {textBox5.Text}";
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {      
            string[] dd = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBox2.Text = dd[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private string AddAtributToString(string sourceString, string distribut)
        {
            return $"<a href=\"{sourceString}\">{distribut}</a>";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] sourceText = textBox1.Text.Split('\n').Select(x => x.Replace("\r", "")).ToArray();
            textBox3.Text = "";
            textBox3.Text += sourceText[0];

            for (int i = 1; i < sourceText.Length; i++)
            {
                //Проверка индекса строки на тот что нужен для ссылки - все действия, что нужно для этой строки
                if (i == Convert.ToInt32(textBox8.Text) - 1)
                {
                    string text = "";
                    if (checkBox1.Checked) 
                    {
                        text = this.AddAtributToString(textBox2.Text, "Ссылка на РИЧ");
                        textBox3.Text += "\r\n</br>" + text;
                    }
                    else
                    {
                        text = this.AddAtributToString(sourceText[int.Parse(textBox8.Text) - 1], "Ссылка на РИЧ");
                        textBox3.Text += "\r\n</br>" + text;
                        continue;
                    } 
                }
                textBox3.Text += "\r\n</br>" + sourceText[i];
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
