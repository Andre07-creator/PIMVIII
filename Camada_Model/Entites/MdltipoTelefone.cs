using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Model.Entites
{
    public class MdltipoTelefone
    {
        public int Id { get; private set; }
        public string Tipo { get; set; }
        public MdltipoTelefone()
        {

        }

        public MdltipoTelefone(string tipo)
        {
            Tipo = tipo;
        }
    }
  
}
