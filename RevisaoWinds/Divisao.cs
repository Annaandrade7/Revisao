using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoWinds
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            label1.Text = " ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txV2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCal_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txV1.Text);
                int b = Convert.ToInt32(txV2.Text);

                int c = a / b;

                label1.Text = c.ToString();
                // MessageBox.Show(c.ToString());

            }
            catch(Exception ex)
            { 
                MessageBox.Show("Erro ao dividir");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
