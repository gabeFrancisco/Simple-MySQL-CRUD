using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;

namespace ClientDatabase
{
    public partial class AddClientForm : Form
    {
        ClientBLL bll = new ClientBLL();
        readonly ManagerForm managerForm;
        readonly ServiceForm serviceForm;
        readonly int Id;
        readonly string mode;
        public AddClientForm(ManagerForm form)
        {
            InitializeComponent();
            managerForm = form;
            mode = "Sign";
        }

        public AddClientForm(ManagerForm form, int id, string name, string phone, string adress)
        {
            InitializeComponent();
            txtName.Text = name;
            txtPhone.Text = phone;
            txtAdress.Text = adress;
            Id = id;
            mode = "Edit";
            managerForm = form;
        }

        public AddClientForm(ServiceForm form)
        {
            InitializeComponent();
            serviceForm = form;
            mode = "ServiceAdd";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (!String.IsNullOrEmpty(txtName.Text)
                                && !String.IsNullOrEmpty(txtPhone.Text)
                                && !String.IsNullOrEmpty(txtAdress.Text))
                {
                    string name = txtName.Text;
                    string phone = txtPhone.Text;
                    string adress = txtAdress.Text;

                    switch (mode)
                    {
                        case "Sign":
                            Client client = new Client(name, phone, adress);
                            bll.AddClient(client);
                            managerForm.UpdateGrid();
                            break;

                        case "Edit":
                            client = new Client(Id, name, phone, adress);
                            bll.EditClient(client);
                            managerForm.UpdateGrid();
                            break;
                        case "ServiceAdd":
                            client = new Client(name, phone, adress);
                            bll.AddClient(client);
                            serviceForm.ComboBoxFill();
                            break;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para continuar!");
                }
            }
            catch (ClientPhoneException ex)
            {
                MessageBox.Show("Erro de cadastro!" + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro inesperado occoreu!");
            }
            
        }

        private void AddClientForm_Load(object sender, EventArgs e) { }
    }
}
