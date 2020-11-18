using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Camada_Model.Entites;
using Camada_Controller.Entites;

namespace PIM_III
{
    public partial class FrmExcluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {
            MdlPessoa pessoaExcluir = new MdlPessoa(null, long.Parse(TxtExluir.Text), null);
            CtlPessoaDAO pessoaDAOExcluir = new CtlPessoaDAO();
            pessoaDAOExcluir.Excluir(pessoaExcluir);
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            MdlPessoa pessoaConsul = new MdlPessoa();
            CtlPessoaDAO pessoaDAO = new CtlPessoaDAO();
            pessoaDAO.Consulta(long.Parse(TxtExluir.Text));
        }
    }
}