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
        public frmClientList(IUserServices userServices)
        {
            _userServices = userServices;
            InitializeComponent();
        }

        private async void UpdateClienteList()
        {
            var teste = await _userServices.GetAllClients();
            var listDataView = new List<ClienteView>();

            if (teste.Error == false)
            {
                foreach (var cliente in teste.Data.Clientes)
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
            frmApolice Apolice = new frmApolice();
            Apolice.Show();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}
