using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            Flowers flowers = new Flowers();

            listBox1.Items.Add(flowers.info(textBox1.Text , comboBox1.Text , textBox3.Text , comboBox2.Text , Convert.ToInt32(textBox2.Text) , Convert.ToInt32(textBox4.Text)));
            listBox1.Items.Add(flowers.Cena(Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox5.Text)));    
            
            int count = listBox1.Items.Count;

            if (count > 10)
            {
                DialogResult result = MessageBox.Show(
                "Отчистить данные?",
                 "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                { 
                    listBox1.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Goodbye");
                    this.Close();
                }
               
                
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Название не введено", "ошибка");
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flowers flowers = new Flowers();
            listBox1.Items.Add(flowers.Cena(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text)));

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

