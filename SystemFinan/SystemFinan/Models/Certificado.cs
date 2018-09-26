using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFinan.Models
{
    public class Certificado
    {
        private int _IdCert;
        private int _TipoCert;
        private int _FormPag;
        private int _Status;
        private DateTime _DataEmissao;
        private string _ParcContab; //Parceira de Contabilidade

        public int IdCert { get; private set; }
        public int TipoCert { get; private set; }
        public int FormPag { get; private set; }
        public int Status { get; private set; }
        public DateTime DataEmissao { get; private set; }

    }
}
