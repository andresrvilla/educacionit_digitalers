<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolaMundo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hola mundo</h1>
            <h1><asp:Label runat="server" ID="lblTituloPagina">Hola Mundo</asp:Label></h1>
            HOLA<br />
            <% Response.Write("Hola mundo " + (1 + 1)); %><br />
            <asp:Label runat="server" ID="lblSaludo">ASDASDAS</asp:Label>

        </div>
    </form>
</body>
</html>
