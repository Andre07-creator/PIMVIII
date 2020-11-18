using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Model.Entites
{
    public class MdlTelefone
    {
    
        public int Id { get; private set; }
        public int Numero { get; set; }
        public int Ddd { get; set; }
        public MdltipoTelefone MdltipoTelefone { get; set; }
        public MdlTelefone()
        {

        }

        public MdlTelefone(int numero, int ddd, MdltipoTelefone mdltipoTelefone)
        {
            
            Numero = numero;
            Ddd = ddd;
            MdltipoTelefone = mdltipoTelefone;
        }
        
       
    }
    
}
