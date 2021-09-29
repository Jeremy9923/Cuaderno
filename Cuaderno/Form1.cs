using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuaderno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.setcolor(textBox4.Text);
            book.sethojas(textBox3.Text);
            book.settamaño(textBox2.Text);

            if (textBox2.Text == "" & textBox3.Text == "" & textBox4.Text == "")
            {
                MessageBox.Show("no se deben dejar cuadros vacios");
            }
            else { 

            listBox1.Items.Add(book.getTodo());

                 }
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox2.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            
            //agregar los datos al ListBox
        
            label1.Text = " Cuaderno";
            label2.Text = "Tamaño";
            label3.Text = " Hojas";
            label4.Text = "Color";
            button1.Text = "Agregar";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
