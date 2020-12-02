using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularIdade_Click(object sender, EventArgs e)
        {
            if (dtpNascimento.Value < DateTime.Now)
            {
                int resultado = CalculaIdade(dtpNascimento.Value);
                lblIdade.Text = $" {resultado} anos";
            }
            else
                MessageBox.Show("Data inválida");
        }
        
        private static int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }
}
