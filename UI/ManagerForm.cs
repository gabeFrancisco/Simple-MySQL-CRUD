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

namespace ClientDatabase
{
    public partial class ManagerForm : Form
    {
        ClientBLL bll = new ClientBLL();
        public ManagerForm()
        {
            InitializeComponent();
            
            gridClient.DataSource = bll.ReturnTable();
           
            gridClient.Columns[0].Width = 45;
            gridClient.Columns[1].Width = 160;
            gridClient.Columns[2].Width = 80;
            gridClient.Columns[3].Width = 300;

            gridClient.Columns[0].DefaultCellStyle.Format = "D4";
            gridClient.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAdress.ReadOnly = true;
            txtId.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm addClient = new AddClientForm(this);
            addClient.ShowDialog();
        }
        private void gridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedIndex = gridClient.Rows[index];

            txtId.Text = String.Format("{0:0000}", selectedIndex.Cells[0].Value.ToString());
            txtName.Text = selectedIndex.Cells[1].Value.ToString();
            txtPhone.Text = selectedIndex.Cells[2].Value.ToString();
            txtAdress.Text = selectedIndex.Cells[3].Value.ToString(); 

        }

        public void UpdateGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bll.ReturnTable();
            gridClient.DataSource = bs;
            gridClient.Update();
        }

        private void btnEraseClient_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Você realmente deseja excluir esse cliente? ", 
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(gridClient.SelectedCells[0].Value.ToString());

                    bll.DeleteClient(id);
                    UpdateGrid();

                    txtName.Clear();
                    txtId.Clear();
                    txtPhone.Clear();
                    txtAdress.Clear();
                }
             
            }
            catch(Exception ex)
            {
                MessageBox.Show("Um erro inesperado ocorreu!: " + ex.Message);
            }
           
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                AddClientForm addClient = new AddClientForm(this, int.Parse(txtId.Text),
                               txtName.Text,
                               txtPhone.Text,
                               txtAdress.Text);

                addClient.ShowDialog();
            }
            catch(FormatException)
            {
                MessageBox.Show("Selecione um cliente da lista!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro occoreu!" + ex.Message);
            }
           
        }

        private void ManagerForm_Load(object sender, EventArgs e) { }
    }
}
