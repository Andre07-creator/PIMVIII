using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Camada_Controller.Entites;
using Camada_Model.Entites;

namespace PIM_III
{
    public partial class FrmConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  
        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            MdlPessoa pessoaConsul = new MdlPessoa();
            CtlPessoaDAO pessoaDAO = new CtlPessoaDAO();
            pessoaDAO.Consulta(long.Parse(TxtConsultar.Text));
        }
    }
}