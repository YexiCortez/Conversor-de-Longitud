<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form{
            width:615px;
        }
        .auto-style7{
            max-width: 800px;
            background: #7fffd4;
            padding:30px;
            margin: 225px auto;
            border-radius:50px;
            border: 6px solid #305A72;
            width: 600px;
        }

        .auto-style1 {
            position: relative;
            left: 2px;
            top: 2px;
            width: 593px;
        }
        .auto-style2 {
            width: 499px;
        }
        .auto-style8 {
            width: 162px;
        }
        .boton {
            text-align: center;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style7">
        <table class="auto-style6">
            <tr>
                <td class="auto-style1" style="font-family: 'Arial Narrow'; font-size: x-large; font-weight: bold; font-style: italic; text-align: center">
                    Covertidor de Medidas de Longitud
                </td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td class="auto-style8">Ingrese el valor:</td>
                <td class="auto-style2"><br /> &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtvalor" runat="server" TextMode="Number" ValidateRequestMode="Enabled"></asp:TextBox>
                    <br /><br /></td>
            </tr>
            <tr>
                <td class="auto-style8">De:</td>
                <td class="auto-style2">

                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="Entrada" runat="server">
                        <asp:ListItem>Milimetros</asp:ListItem>
                        <asp:ListItem>Centimetros</asp:ListItem>
                        <asp:ListItem>Metros</asp:ListItem>
                        <asp:ListItem>Kilometros</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">A:</td>
                <td class="auto-style2">

                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="Salida" runat="server">
                        <asp:ListItem>Milimetros</asp:ListItem>
                        <asp:ListItem>Centimetros</asp:ListItem>
                        <asp:ListItem>Metros</asp:ListItem>
                        <asp:ListItem>Kilometros</asp:ListItem>
                    </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td colspan="2"; class="boton">
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Convertir" Width="127px" CssClass="boton" />

                </td>
            </tr>
            <tr>
                <td colspan="2"; class="boton">
                    <asp:Button ID="Nuevo" runat="server" Text="Nuevo" Width="127px" />
                </td>
            </tr>
            <tr>
                <td colspan="2"; class="boton">
                     <br /> Resultado <br />
                    <asp:TextBox ID="lblr" runat="server" Width="89px"></asp:TextBox>
                    &nbsp;<asp:TextBox ID="lblum" runat="server" Width="30px"></asp:TextBox>
        <br />
                </td>
            </tr>
        </table>

       


    </form>
</body>
</html>
