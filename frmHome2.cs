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
    public partial class frmHome2 : Form
    {
        public frmHome2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
