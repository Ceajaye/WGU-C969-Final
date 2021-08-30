using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_App
{
    class LoginException : ApplicationException
    {
        public LoginException() : base("Incorrect form input")
        {

        }
        public LoginException(string exemptionMessage) : base(exemptionMessage)
        {

        }
        public LoginException(string exemptionMessage, ApplicationException inner) : base(exemptionMessage, inner)
        {

        }
    }
}
