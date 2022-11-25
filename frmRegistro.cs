using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login_e_Registro_Sistema.Services.Interfaces;
using Login_e_Registro_Sistema.Models;
using Microsoft.Win32;

namespace Login_e_Registro_Sistema
{
    public partial class frmRegistro : Form
    {
        public readonly IUserServices _userServices; 
        public frmRegistro(IUserServices userServices)
        {
            _userServices = userServices;
            InitializeComponent();
        }

        private async void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var frm = await Registrar(
                txtNomeCompleto.Text,
                txtNomeUsuario.Text,
                txtSenha.Text,
                txtConfirmacaoSenha.Text,
                txtDocumento.Text
                );

            txtNomeUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmacaoSenha.Text = "";
            txtNomeCompleto.Text = "";
            txtDocumento.Text = "";

        }

        private async Task<bool> Registrar(string name, 
            string username, string password, 
            string repassword, string document)

        {
            var userRegister = new UserRegister
            {
                Name = name,
                Username = username,
                Password = password,
                Repassword = repassword,
                Document = document
            };

            var test = await _userServices.RegisterUser(userRegister);

            if (test.Error == false)
            {
                Console.WriteLine(test.Data);

                MessageBox.Show("Registrado com sucesso");

            }
            else
            {
                MessageBox.Show("Erro!");
            }

            return true;
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtConfirmacaoSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
                txtConfirmacaoSenha.PasswordChar = '*';
            }
        }

        private void buttonLimparCadastrar_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmacaoSenha.Text = "";
            txtNomeCompleto.Text = "";
            txtDocumento.Text = "";
            txtNomeUsuario.Focus();
        }

        private void rLogin_Click(object sender, EventArgs e)
        {
        }
    }
}