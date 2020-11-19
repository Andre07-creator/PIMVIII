
<%@ Page Title="Adicionar pessoas" Language="C#" AutoEventWireup="true" CodeBehind="FrmPessoa.aspx.cs" Inherits="PIM_III.FrmPessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            background-color: #F0F0F0;
        }
    </style>
</head>
<body style="height: 551px; width: 1327px; font-weight: 700; font-size: large; background-color: #F0F0F0">
    <form id="form1" runat="server">
        <div class="col-md-4">
            <h2 style="height: 27px; margin-top: 14px; background-color: #CCCCFF;">Inserir dados</h2>
        </div>
        <br />
    <asp:label runat="server" text="Nome:" ID="LblNome"></asp:label>
        <asp:TextBox ID="TxtNome" runat="server" style="margin-left: 14px" OnTextChanged="TxtId_TextChanged" Wrap="False" Width="202px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCpf" runat="server" Text="Cpf:    "></asp:Label>
            <asp:TextBox ID="TxtCpf" runat="server" Width="183px"></asp:TextBox>
        </p>
        <asp:Label ID="LblAdiconarTell" runat="server" Text="Adiocinar telefones:"></asp:Label>
        <br />
        <asp:Label ID="LblDDD" runat="server" Text="DDD:  "></asp:Label>
        <asp:TextBox ID="TxtDDD" runat="server" Width="65px" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="LblNumero" runat="server" Text="Número:  "></asp:Label>
        <asp:TextBox ID="TxtTelNumero" runat="server"></asp:TextBox>
        <asp:Label ID="LblTipo" runat="server" Text="Tipo: "></asp:Label>
        <asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox>
        <asp:Button ID="btlAdicionarTel" runat="server" OnClick="btlAdicuinarTel_Click" Text="Adicionar" style="font-size: medium; font-weight: 700; background-color: #99CCFF" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <p>
        <asp:Label ID="LblEndereço" runat="server" Text="Endereço:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="LblLogradouro" runat="server" Text="Logradouro: "></asp:Label>
            <asp:TextBox ID="TxtLogradouro" runat="server"></asp:TextBox>
            <asp:Label ID="LblEndNumero" runat="server" Text="Número: "></asp:Label>
            <asp:TextBox ID="TxtEndNumero" runat="server" Width="61px"></asp:TextBox>
            <asp:Label ID="LblCep" runat="server" Text="CEP: "></asp:Label>
            <asp:TextBox ID="TxtCep" runat="server"></asp:TextBox>
            <asp:Label ID="LblBairro" runat="server" Text="Bairro: "></asp:Label>
            <asp:TextBox ID="TxtBairro" runat="server"></asp:TextBox>
            <asp:Label ID="LblBairro0" runat="server" Text="Cidade: "></asp:Label>
            <asp:TextBox ID="TxtCidade" runat="server"></asp:TextBox>
            <asp:Label ID="LblBairro1" runat="server" Text="Estado: "></asp:Label>
            <asp:TextBox ID="TxtEstado" runat="server" Width="106px"></asp:TextBox>
        </p>
        <asp:Button ID="BtnInsere" runat="server" OnClick="BtnCadastrar_Click" Text="Inserir" Height="33px" style="margin-left: 9px; font-size: medium; font-weight: 700; background-color: #99CCFF;" Width="86px" />
    </form>
    </body>
</html>

