using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_e_Registro_Sistema
{
    public partial class frmApolice : Form
    {
        public frmApolice()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmHPagamento HP = new frmHPagamento();
            HP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHSinistro HS = new frmHSinistro();
            HS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFinanceiro Fina = new frmFinanceiro();
            Fina.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFinanceiro Fina = new frmFinanceiro();
            Fina.Show();
        }
    }
}
