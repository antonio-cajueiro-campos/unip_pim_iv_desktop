using Login_e_Registro_Sistema.Models;
using Login_e_Registro_Sistema.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_e_Registro_Sistema
{
    public partial class frmLogin : Form
    {
        public readonly IUserServices _userServices;
        public frmLogin(IUserServices userServices)
        {
            _userServices = userServices;
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void buttonLogar_Click(object sender, EventArgs e)
        {
            var credential = new Credential
            {
                Username = txtNomeUsuario.Text,
                Password = txtSenha.Text
            };

            var test = await _userServices.LoginUser(credential);

            if (((int?)test.Status) == 200)
            {
                Console.WriteLine(test.Data);

                MessageBox.Show("Seja bem vindo");

                //para fechar a Janela anterior
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha invalida!");
            }


            ///frmHome Home1 = new frmHome();
            ///Home1.Show();
            ///
            /////para fechar a Janela anterior
            ///this.Visible =  false;
        }

        private void cadastrarFuncionario_Click(object sender, EventArgs e)
        {
            frmRegistro Registro = new frmRegistro(_userServices);
            Registro.Show();
        }
    }
}
