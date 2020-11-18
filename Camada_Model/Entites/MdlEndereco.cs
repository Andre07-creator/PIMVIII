using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Camada_Model.Entites
{
    public class MdlEndereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public MdlEndereco()
        {

        }

        public MdlEndereco( string logradouro, int numero, 
            int cep, string bairro, string cidade, string estado)
        {          
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    } 
}
