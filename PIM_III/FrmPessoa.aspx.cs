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
    public partial class FrmPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void TxtId_TextChanged(object sender, EventArgs e)
        {

        }    

        protected void btlAdicuinarTel_Click(object sender, EventArgs e)
        {
            MdltipoTelefone mdltipo = new MdltipoTelefone(TxtTipo.Text);       
            MdlTelefone telefone = new MdlTelefone(int.Parse(TxtTelNumero.Text),
                int.Parse(TxtDDD.Text), mdltipo);

            MdlPessoa Adicionartel = new MdlPessoa();
            Adicionartel.Add(telefone);
            TxtTelNumero.Text = string.Empty;
            TxtDDD.Text = string.Empty;
            TxtTipo.Text = string.Empty;
            TxtDDD.Focus();
           
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            

            MdlEndereco mdlEndereco = new MdlEndereco(TxtLogradouro.Text, int.Parse(TxtEndNumero.Text),
                int.Parse(TxtCep.Text), TxtBairro.Text, TxtCidade.Text, TxtEstado.Text);


            MdlPessoa mdlPessoa = new MdlPessoa(TxtNome.Text, long.Parse(TxtCpf.Text), mdlEndereco);
           
            CtlPessoaDAO ctlPessoa = new CtlPessoaDAO();
            ctlPessoa.Insira(mdlPessoa);

            TxtNome.Text = string.Empty;
            TxtCpf.Text = string.Empty;
            TxtLogradouro.Text = string.Empty;
            TxtEndNumero.Text = string.Empty;
            TxtCep.Text = string.Empty;
            TxtBairro.Text = string.Empty;
            TxtCidade.Text = string.Empty;
            TxtEstado.Text = string.Empty;
            TxtNome.Focus();
            
            
        }
    }
}