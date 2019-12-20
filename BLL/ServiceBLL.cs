using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Data;

namespace BLL
{
    public class ServiceBLL
    {

        ServiceDataAcess serviceData = new ServiceDataAcess();

        public DataTable ReturnData()
        {
            return serviceData.ReturnTable();
        }

        public void AddService(Service service)
        {
            string client = service.Client;
            string title = service.Title;
            string desc = service.ServiceDescription;

            serviceData.InsertService(client, title, desc);
        }

        public void DeleteService(int index)
        {
            serviceData.DeleteItem(index);
        }

        public void EditService(Service service)
        {
            string client = service.Client;
            string title = service.Title;
            string desc = service.ServiceDescription;
            int id = service.Id;

            serviceData.UpdateData(id, client, title, desc);
        }
    }
}
