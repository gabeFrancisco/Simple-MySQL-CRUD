using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;

namespace ClientDatabase
{
    public partial class ServiceForm : Form
    {
        ServiceBLL bll = new ServiceBLL();
        static ClientBLL client_bll = new ClientBLL();
        public ServiceForm()
        {
            InitializeComponent();
            dtService.DataSource = bll.ReturnData();

            dtService.RowTemplate.Height = 50;

            dtService.Columns[0].Width = 40;
            dtService.Columns[0].HeaderText = "ID";
            dtService.Columns[0].DefaultCellStyle.Format = "d4";
            dtService.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtService.Columns[1].HeaderText = "TÍTULO";
            dtService.Columns[1].Width = 130;
            dtService.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dtService.Columns[2].HeaderText = "DESCRIÇÃO DO SERVIÇO";
            dtService.Columns[2].Width = 270;
            dtService.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dtService.Columns[3].HeaderText = "CLIENTE";
            dtService.Columns[3].Width = 160;

            ComboBoxFill();
            btnOkEdit.Enabled = false;
        }

        public void ComboBoxFill()
        {
            cbClients.DataSource = client_bll.ReturnTable();
            cbClients.DisplayMember = "Name";
        }
        private void ServiceForm_Load(object sender, EventArgs e) { dtService.ClearSelection(); }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtTitle.Text)
                                   && !String.IsNullOrEmpty(txtService.Text)
                                   && !String.IsNullOrEmpty(cbClients.SelectedItem.ToString()))
                {
                    string clientName = cbClients.Text;
                    string title = txtTitle.Text;
                    string desc = txtService.Text;

                    Service service = new Service(clientName, title, desc);
                    bll.AddService(service);

                    UpdateGrid();

                    txtTitle.Clear();
                    txtService.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            catch(Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bll.ReturnData();
        }

        public void UpdateGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bll.ReturnData();
            dtService.DataSource = bs;
            dtService.Update();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Você deseja realmente excluir esse serviço?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int index = int.Parse(dtService.SelectedCells[0].Value.ToString());

                    bll.DeleteService(index);

                    UpdateGrid();
                }
            }
            catch { MessageBox.Show("Nenhum serviço selecionado!"); }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddService.Enabled = false;
                btnDeleteService.Enabled = false;
                btnEditService.Enabled = false;
                btnOkEdit.Enabled = true;

                txtTitle.Text = dtService.SelectedCells[1].Value.ToString();
                txtService.Text = dtService.SelectedCells[2].Value.ToString();
                cbClients.Text = dtService.SelectedCells[3].Value.ToString();
            }
            catch { MessageBox.Show("Nenhum serviço selecionado!"); }
         
        }

        private void btnOkEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtService.SelectedCells[0].Value.ToString());
            string title = txtTitle.Text;
            string desc = txtService.Text;
            string name = cbClients.Text;

            Service service = new Service(id, name, title, desc);
            bll.EditService(service);

            btnAddService.Enabled = true;
            btnDeleteService.Enabled = true;
            btnEditService.Enabled = true;
            btnOkEdit.Enabled = false;

            UpdateGrid();

            txtTitle.Clear();
            txtService.Clear();
        }

        private void btnAddClientSv_Click(object sender, EventArgs e)
        {
            AddClientForm addClient = new AddClientForm(this);
            addClient.ShowDialog();
        }
    }
}
