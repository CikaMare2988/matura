<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="../css/StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
            <b><p>Knjiga Utisaka</p></b>
        </div>
        <div class="div2">

            <asp:Button class="button" ID="Button1" runat="server" Text="Pocetna" Width="76px" onClick="Button1_Click"/>
            <asp:Button class="button" ID="Button2" runat="server" Text="O Autoru" Width="76px" onClick="Button2_Click"/>
            <asp:Button class="button" ID="Button3" runat="server" Text="Uputstvo" Width="76px" onClick="Button3_Click"/>

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Ime:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBoxIme" runat="server" Width="195px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ime je obavezno polje" Display="Dynamic" ForeColor="Red" ControlToValidate="TextBoxIme" ValidationGroup="Primer1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email:</td>
                <td>
                    <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" Width="194px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="E-mail nije u ispravnom formatu" Display="Dynamic" ForeColor="Red" ControlToValidate="TextBoxEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Primer1"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Komentar:</td>
                <td>
                    <asp:TextBox ID="TextBoxKomentar" runat="server" Height="78px" Width="193px" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Komentar je obavezno polje" ForeColor="Red" Display="Dynamic" ControlToValidate="TextBoxKomentar" ValidationGroup="Primer1"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Dodaj Komentar" Width="109px" OnClick="Button4_Click" ValidationGroup="Primer1" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
