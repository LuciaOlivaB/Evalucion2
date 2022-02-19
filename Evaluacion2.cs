using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1._0
{
    public partial class Evaluacion2 : Form
    {
        public Evaluacion2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recurrir ((comboBox1.Text), Convert.ToInt32(comboBox2.Text));
        }
        
        private void Recurrir(string estudiante, int edad) 
        {
            listBox1.Items.Add(estudiante);

            if (edad > 0) 
            {
                Recurrir(estudiante, edad + 1);
            }
        }
    }
}
