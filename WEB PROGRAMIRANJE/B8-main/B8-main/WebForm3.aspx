<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .div1{
            height:50px;
            background-color:steelblue;
        }
        .div2{
            height:30px;
            background-color:midnightblue;
        }
        .div3{
            font-size:30px;
            padding-left:50px;
        }
        .button{
            background-color:royalblue;
            color:white;
        }
        p{
            color:white;    
            padding-top:15px;
            padding-left:10px;
            font-size:20px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 109px;
        }
        .auto-style3 {
            width: 109px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
            <b><p>Knjiga Utisaka</p></b>
        </div>
        <div class="div2">

            <asp:Button class="button" ID="Button1" runat="server" Text="Pocetna" Width="76px" />
            <asp:Button class="button" ID="Button2" runat="server" Text="O Autoru" Width="76px" />
            <asp:Button class="button" ID="Button3" runat="server" Text="Uputstvo" Width="76px" />

        </div>
        <div class="div3">
            Ovo je sajt hotela, koji sluzi da korisnici unesu svoju recenziju
        </div>
    </form>
</body>
</html>
