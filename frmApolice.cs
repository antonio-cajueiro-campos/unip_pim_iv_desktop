using Login_e_Registro_Sistema.Models;
using Login_e_Registro_Sistema.Services.Interfaces;
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
        public readonly IUserServices _userServices;
        public readonly Cliente _clientInfo;

        public frmApolice(IUserServices userServices, ApoliceCliente apolice, Cliente clientInfo)
        {
            _userServices = userServices;
            _clientInfo = clientInfo;

            InitializeComponent();
            
            textBoxApoNome.Text = clientInfo.User?.Name;
            textBoxApoDoc.Text = clientInfo.User?.Document;
            textBoxNCasa.Text = clientInfo.Endereco?.Numero;
            textBoxCEP.Text = clientInfo.Endereco?.Cep;
            textBoxComplemento.Text = clientInfo.Endereco?.Complemento;
            textBoxTell.Text = clientInfo.Telefone;

            textBoxIRE.Text = apolice?.Sinistros["IRE"].ToString();
            textBoxRO.Text = apolice?.Sinistros["RO"].ToString();
            textBoxDE.Text = apolice?.Sinistros["DE"].ToString();
            textBoxRCF.Text = apolice?.Sinistros["RCF"].ToString();
            textBoxVGC.Text = apolice?.Sinistros["VGC"].ToString();
            textBoxPP.Text = apolice?.Sinistros["PP"].ToString();

            textBoxDateVi.Text = apolice?.Vigencia.ToShortDateString();
            textBoxDateEm.Text = apolice?.Emissao.ToShortDateString();
            textBoxVC.Text = apolice?.ValorCobertura.ToString();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var checkedButton = sinistrosGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (checkedButton == null)
            {
                MessageBox.Show("Selecione um tipo de sinistro para ativar");
                return;
            }

            var result = await _userServices.ActiveInsurance(_clientInfo.Id, checkedButton.Tag.ToString());

            if (result.Error == true)
            {
                MessageBox.Show("Não foi possível ativar a apolice do cliente");
                return;
            }

            MessageBox.Show("Apolice foi ativada com sucesso e dinheiro transferido para o PIX do cliente");
        }

        private void frmApolice_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApoDateNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApoDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
