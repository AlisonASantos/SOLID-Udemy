using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    class ControladorEmail
    {
        public bool ValidarEmail(string email)
        {
            var address = new System.Net.Mail.MailAddress(email);

            return address.Address == email;
        }

        public void EnviarEmail(string email, string massage)
        {
            //string conection = netManeger.GetCon();
            //netManeger.Send(email);
        }
    }
}
