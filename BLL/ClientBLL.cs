using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using System.Data;

namespace BLL
{
    public class ClientBLL
    {
        ClientDataAcess clientData = new ClientDataAcess();
        public ClientBLL() { }

        public void AddClient(Client client)
        {
            try
            {
                string name = client.Name;
                string phone = client.Phone;
                string adress = client.Adress;

                if (client.Phone.Length < 11)
                {
                    throw new ClientPhoneException("The phone is in an incorrect format! Are you missing or overtyping the number?");
                }
                else
                {
                    clientData.InsertData(name, phone, adress);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ReturnTable()
        {
            return clientData.ReturnData();
        }

        public void DeleteClient(int id)
        {
            clientData.RemoveData(id);
        }

        public void EditClient(Client client)
        {
            int id = client.Id;
            string name = client.Name;
            string phone = client.Phone;
            string adress = client.Adress;

            clientData.UpdateData(id, name, phone, adress);
        }
    }
}
