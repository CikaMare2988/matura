<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uputstvo.aspx.cs" Inherits="WebApplication2.Uputstvo" %>

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
        <div>
            Ovo je sajt za dodavanje komentara o utisku naseg hotela. Potrebno je popuniti osnovnim informacijama kao sto je ime, email i komentar. Podaci se ubacuju u nasoj bazi!
        </div>
    </form>
</body>
</html>