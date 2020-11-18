﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmConsulta.aspx.cs" Inherits="PIM_III.FrmConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            border-style: outset;
            height: 136px;
            font-weight: 700;
            font-size: large;
        }
    </style>
</head>
<body style="background-color: #F0F0F0">
    <form id="form1" runat="server">
        <div class="col-md-4">
            <h2>Consultar Dados</h2>
        </div>
        <asp:Label ID="LblDigiCpf" runat="server" Text="Digite o Cpf: " style="font-size: large"></asp:Label>
        <asp:TextBox ID="TxtConsultar" runat="server" OnTextChanged="TxtConsultar_TextChanged"></asp:TextBox>
        <asp:Button ID="BtnConsultar" runat="server" OnClick="BtnConsultar_Click" Text="Consultar" style="font-size: medium; font-weight: 700; background-color: #99CCFF" />
        <br />
        <br />
        <div class="col-md-4">
            <h3 style="font-size: large">Exibindo resultado da consulta:</h3>
        </div>
    <asp:label runat="server" text="Nome:" ID="LblNome"></asp:label>
        <asp:TextBox ID="TxtNome" runat="server" style="margin-left: 14px" OnTextChanged="TxtId_TextChanged" Wrap="False"></asp:TextBox>
        <p>
            <asp:Label ID="lblCpf" runat="server" Text="Cpf "></asp:Label>
            :<asp:TextBox ID="TxtCpf" runat="server" Width="126px"></asp:TextBox>
        </p>
        Exibindo telefones:<br />
        <br />
        <asp:Label ID="LblDDD" runat="server" Text="DDD:  "></asp:Label>
        <asp:TextBox ID="TxtDDD" runat="server" Width="65px" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="LblNumero" runat="server" Text="Numero:  "></asp:Label>
        <asp:TextBox ID="TxtTelNumero" runat="server"></asp:TextBox>
        <asp:Label ID="LblTipo" runat="server" Text="Tipo: "></asp:Label>
        <asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="DDD:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="65px" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Numero:  "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Tipo: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
        <p> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; XXXXXXX&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  XXXXX&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; XXXX XXX</p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <p>
        <asp:Label ID="LblEndereço" runat="server" Text="Endereço:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="LblLogradouro" runat="server" Text="Logradouro: "></asp:Label>
            <asp:TextBox ID="TxtLogradouro" runat="server"></asp:TextBox>
            <asp:Label ID="LblEndNumero" runat="server" Text="Numero: "></asp:Label>
            <asp:TextBox ID="TxtEndNumero" runat="server"></asp:TextBox>
            <asp:Label ID="LblCep" runat="server" Text="CEP: "></asp:Label>
            <asp:TextBox ID="TxtCep" runat="server"></asp:TextBox>
            <asp:Label ID="LblBairro" runat="server" Text="Bairro: "></asp:Label>
            <asp:TextBox ID="TxtBairro" runat="server"></asp:TextBox>
            <asp:Label ID="LblBairro0" runat="server" Text="Cidade: "></asp:Label>
            <asp:TextBox ID="TxtCidade" runat="server"></asp:TextBox>
            <asp:Label ID="LblBairro1" runat="server" Text="Estado: "></asp:Label>
            <asp:TextBox ID="TxtEstado" runat="server"></asp:TextBox>
        </p>
        </form>
    <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color: #F0F0F0">
    </body>
</html>
</body>
</html>
