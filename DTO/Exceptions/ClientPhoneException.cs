using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientPhoneException : ApplicationException
    {
        public ClientPhoneException(string message) : base(message) { }
    }
}
