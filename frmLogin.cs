using Login_e_Registro_Sistema.Models;
using Login_e_Registro_Sistema.Services;
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
        public readonly IRequestServices _requestService;
        public frmLogin()
        {
            _requestService = new RequestService();
            _userServices = new UserService(_requestService);

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

            var outputLogin = await _userServices.LoginUser(credential);

            if (outputLogin.Status == 200)
            {
                MessageBox.Show("Seja bem vindo");
                txtNomeUsuario.Text = "";
                txtSenha.Text = "";
                this.Visible = false;
                frmHome Home1 = new frmHome(_userServices);
                Home1.Show();

            }
            else
            {
                MessageBox.Show("Usuario ou Senha invalida!");
                txtNomeUsuario.Text = "";
                txtSenha.Text = "";
            }
        }

        private void cadastrarFuncionario_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = "";
            txtSenha.Text = "";
            this.Visible = false;
            frmRegistro Registro = new frmRegistro(_userServices);
            Registro.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimparLogin_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = "";
            txtSenha.Text = "";
            txtNomeUsuario.Focus();
        }
    }
}
