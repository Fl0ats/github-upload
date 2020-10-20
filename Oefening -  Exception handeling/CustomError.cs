using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening____Exception_handeling
{
     class CustomError : System.ApplicationException
    {
        public CustomError()
        {

        }

        public CustomError(string message) : base(message)
        {

        }

        public CustomError(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
