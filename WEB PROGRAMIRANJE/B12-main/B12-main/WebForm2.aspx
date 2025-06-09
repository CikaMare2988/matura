<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="B12.WebForm2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <p>Rezervacija autobskih karata</p>
            </header>
        </div>

        <div class="menu">
    <asp:Button class="dumge" ID="Button1" runat="server" Text="Pocetna" OnClick="Button1_Click" />
    <asp:Button class="dumge" ID="Button2" runat="server" Text="O Autoru" OnClick="Button2_Click"/>
    <asp:Button class="dumge" ID="Button3" runat="server" Text="Uputstvo" OnClick="Button3_Click"/>
</div>

        
        
    </form>

    <p>
        Ovo je projekat u kojem korisnik moze rezervisati autobusku kartu, klikom na sediste koje zeli da rezervise.
</p>
    </body>
</html>
