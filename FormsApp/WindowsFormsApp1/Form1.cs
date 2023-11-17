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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNome.Text = lblNome.Text + name.Text;
            lblCPF.Text = lblCPF.Text + cpf.Text;
            lblNascimento.Text = lblNascimento.Text + state.Text;
            if(rdbOne.Checked == true)
                {
                    lblcasal.Text = lblcasal.Text + "solteiro";
                }
            else if(rdbTwo.Checked == true)
            {
                lblcasal.Text = lblcasal.Text + "casado";
            }
            else
            {
                lblcasal.Text = lblcasal.Text + "viuvo";
            }
            lblage.Text = lblage.Text + idade.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbOne_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
