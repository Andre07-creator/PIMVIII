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
    public partial class FrmAlterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void BtnAlterar_Click(object sender, EventArgs e)
        {

            MdltipoTelefone mdltipo = new MdltipoTelefone(TxtTipo.Text);
            MdlTelefone telefoneAltera = new MdlTelefone(int.Parse(TxtTelNumero.Text),
                int.Parse(TxtDDD.Text), mdltipo);

            CtlPessoaDAO pessoaDAOAlterar = new CtlPessoaDAO();

            MdlEndereco mdlEnderecoAltera = new MdlEndereco(TxtLogradouro.Text, int.Parse(TxtEndNumero.Text),
                int.Parse(TxtCep.Text), TxtBairro.Text, TxtCidade.Text, TxtEstado.Text);

            MdlPessoa pessoaAltera = new MdlPessoa(TxtNome.Text, long.Parse(TxtConsultar.Text), mdlEnderecoAltera);

            pessoaDAOAlterar.Alterar(pessoaAltera, telefoneAltera);
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            MdlPessoa pessoaConsul = new MdlPessoa();
            CtlPessoaDAO pessoaDAO = new CtlPessoaDAO();
            pessoaDAO.Consulta(long.Parse(TxtConsultar.Text));
        }
    }
}