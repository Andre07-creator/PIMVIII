using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Camada_Model.Entites
{
    public class MdlPessoa
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public MdlEndereco MdlEndereco { get; set; }
        public List<MdlTelefone> mdlTelefones = new List<MdlTelefone>();

        public MdlPessoa()
        {

        }

        public MdlPessoa(string nome, long cpf, MdlEndereco mdlEndereco)
        {
            
            Nome = nome;
            Cpf = cpf;
            MdlEndereco = mdlEndereco;
            mdlTelefones = new List<MdlTelefone>();
        }
       
            
        

        public void Add(MdlTelefone telefone)
        {
            mdlTelefones.Add(telefone);
        }
    }
    
}
