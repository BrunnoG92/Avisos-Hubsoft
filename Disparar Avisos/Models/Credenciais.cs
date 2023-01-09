using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disparar_Avisos.Models
{
    public class Credenciais
    {
        private static Credenciais instance;

        private Credenciais()
        {
        }

        public static Credenciais Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Credenciais();
                }
                return instance;
            }
        }

        public string GrantType { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
        public string UserName { get; set; }
        public string HostAutentica { get; set; }
        public string HostConsulta { get; set; }
        public string Password { get; set; }
        public List<string> Email_Destinatario = new List<string>();
        public string EmailRemetente { get; set; }
        public string SenhaEmail { get; set; }
        public string HostEmail { get; set; }
       
    }

}
