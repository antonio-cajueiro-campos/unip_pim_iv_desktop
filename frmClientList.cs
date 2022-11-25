using Login_e_Registro_Sistema.Models;
using Login_e_Registro_Sistema.Services;
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
    public partial class frmClientList : Form
    {
        public readonly IUserServices _userServices;

        public ClienteOutput _clientInfos;

        public frmClientList(IUserServices userServices)
        {
            _userServices = userServices;
            InitializeComponent();
        }

        private async void UpdateClienteList()
        {
            var clientResponse = await _userServices.GetAllClients();
            _clientInfos = clientResponse.Data;

            var listDataView = new List<ClienteView>();

            if (clientResponse.Error == false)
            {
                foreach (var cliente in _clientInfos.Clientes)
                {
                    listDataView.Add(
                        new()
                        {
                            Cep = cliente?.Endereco?.Cep,
                            Numero = cliente?.Endereco?.Numero,
                            UserName = cliente.User.Name,
                            Id = cliente.Id,
                            ChavePIX = cliente?.ChavePIX,
                            Telefone = cliente?.Telefone
                        }
                    );
                }

                dataGridView1.DataSource = listDataView;
            }
            else
            {
                MessageBox.Show("Sem clientes/Erro");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmClientList_Load(object sender, EventArgs e)
        {

        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
                      
        }

        private void btnAtuList_Click(object sender, EventArgs e)
        {
             UpdateClienteList();
        }

        private async void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                var userId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                var apoliceResponse = await _userServices.GetApoliceById(userId);
                // chamar o form de infos, dai eu passo o _clientInfos, e o apolice

                var apolice = apoliceResponse.Data;

                var currentClient = _clientInfos.Clientes.FirstOrDefault(c => c.Id == Convert.ToInt32(userId));

                var formApolice = new frmApolice(_userServices, apolice, currentClient);

                formApolice.Show();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
