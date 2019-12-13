using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        private string _name;
        private string _phone;
        private string _adress;

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
            this.ValidatePhone();
        }

        public void ValidatePhone()
        {
            if(this.Phone.Length < 11 && this.Phone.Length > 11)
            {
                throw new ClientPhoneException("The phone is in an incorrect format! Are you missing or overtyping the number?");
            }
        }
    }
}
