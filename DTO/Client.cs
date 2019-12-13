using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _adress;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }
        public string Adress
        {
            get { return this._adress; }
            set { this._adress = value; }
        }

        public Client() { }
        public Client(string name, string phone, string adress)
        {
            this.Name = name;
            this.Phone = phone;
            this.Adress = adress;
        }

        public Client(int id, string name, string phone, string adress)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Adress = adress;
        }

    }
}
