using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "gansosaker@yahoo.fr";
        public string MailFromAddress = "gansosaker@yahoo.fr";
        public bool UseSsl = true;
        public string Username = "gansosaker@yahoo.fr";
        public string Password = "";
        public string ServerName = "smtp@gmail.com";
        public int ServerPort = 587;
    }
}
