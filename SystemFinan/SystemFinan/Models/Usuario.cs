using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFinan.Models
{
    public class Usuario
    {
        private int _IdUser;
        private string _Nome;
        private string _Email;
        private int _Telefone;
        private int _Matricula;
        private int _Status;

        public int IdUser { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Telefone { get; private set; }
        public int Matricula { get; private set; }
        public int Status { get; private set; }

    }
}
