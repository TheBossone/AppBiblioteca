using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario
            Form2 form2 = new Form2();

            // Muestra el nuevo formulario
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario
            Form3 form3 = new Form3();

            // Muestra el nuevo formulario
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario
            Form4 form4 = new Form4();

            // Muestra el nuevo formulario
            form4.Show();
        }
    }
}
