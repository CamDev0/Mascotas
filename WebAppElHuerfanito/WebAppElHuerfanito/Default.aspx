<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppElHuerfanito._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 class="text-center" style="color: #CC33FF">Mascotas El Huerfanito</h1>
        <p class="lead">Consulte las mascotas en adopción, por código.</p>
        <p class="lead">&nbsp;</p>
        <p class="lead">ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Nombre:&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="lead">Edad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEdad" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="lead">Tipo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTipo" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="lead">Color:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtColor" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Label ID="lbMessage" runat="server" Font-Bold="True" ForeColor="#CC33FF"></asp:Label>
        </p>
        <p class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnConsultar" runat="server" ForeColor="#0066FF" Height="45px" OnClick="btnConsultar_Click" Text="Consultar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBorrar" runat="server" ForeColor="#0066FF" Height="43px" OnClick="btnBorrar_Click" Text="Otra Consulta" Width="163px" />
        </p>
    </div>

</asp:Content>
