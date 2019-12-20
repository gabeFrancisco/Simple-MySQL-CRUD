using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Service
    {
        private int _id;
        private string _client;
        private string _title;
        private string _serviceDesc;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Client
        {
            get { return this._client; }
            set { this._client = value; }
        }

        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public string ServiceDescription
        {
            get { return this._serviceDesc; }
            set { this._serviceDesc = value; }
        }

        public Service() { }

        public Service(string client, string title, string desc)
        {
            this.Client = client;
            this.Title = title;
            this.ServiceDescription = desc;
        }

        public Service(int id, string client, string title, string serviceDescription)
        {
            Id = id;
            Client = client;
            Title = title;
            ServiceDescription = serviceDescription;
        }
    }
}
