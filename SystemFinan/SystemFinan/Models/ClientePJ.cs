using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFinan.Models
{
    public class ClientePJ
    {
        private int _IdClientPj;
        private int _Cnpj;
        private string _RazSocial;
        private string _PesRespon;
        private string _Email;
        private int _Telefone;

        public int IdClientPj { get; private set; }
        public int Cnpj { get; private set; }
        public string RazSocial { get; private set; }
        public string PesRepon { get; private set; }
        public string Email { get; private set; }
        public int Telefone { get; private set; }
    }
}
