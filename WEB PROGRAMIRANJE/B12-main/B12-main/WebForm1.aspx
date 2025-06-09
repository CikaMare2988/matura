<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="B12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <link rel="stylesheet" type="text/css" href="../css/StyleSheet2.css">
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

    <div class="naslov">
        <br />
            PRIKAZ SEDISTA AUTOBUSA:

        <br />
        <br />
        <table ID="tblDugmad" class="auto-style7"  runat="server" >
            <tr>
                <td class="auto-style9">
                    <asp:Button  ID="sediste2" runat="server" Text="2" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="sediste3" runat="server" Text="3" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="sediste4" runat="server" Text="4" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td>
                    <asp:Button ID="sediste5" runat="server" Text="5" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="sediste6" runat="server" Text="6" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="sediste7" runat="server" Text="7" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="sediste8" runat="server" Text="8" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td>
                    <asp:Button ID="sediste9" runat="server" Text="9" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="sediste10" runat="server" Text="10" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="sediste11" runat="server" Text="11" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="sediste12" runat="server" Text="12" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
                <td>
                    <asp:Button ID="sediste13" runat="server" Text="13" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
                </td>
            </tr>
            <tr>
                 <td class="auto-style9">
     <asp:Button ID="sediste14" runat="server" Text="14" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
 </td>
 <td class="auto-style10">
     <asp:Button ID="sediste15" runat="server" Text="15" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
 </td>
 <td class="auto-style8">&nbsp;</td>
 <td class="auto-style10">
     <asp:Button ID="sediste16" runat="server" Text="16" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
 </td>
 <td>
     <asp:Button ID="sediste17" runat="server" Text="17" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
 </td>
            </tr>
            <tr>
                                <td class="auto-style9"> 
    <asp:Button ID="sediste18" runat="server" Text="18" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste19" runat="server" Text="19" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste20" runat="server" Text="20" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste21" runat="server" Text="21" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                               <td class="auto-style9">
    <asp:Button ID="sediste22" runat="server" Text="22" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste23" runat="server" Text="23" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste24" runat="server" Text="24" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste25" runat="server" Text="25" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                               <td class="auto-style9">
    <asp:Button ID="sediste26" runat="server" Text="26" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10"> 
    <asp:Button ID="sediste27" runat="server" Text="27" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste28" runat="server" Text="28" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste29" runat="server" Text="29" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                               <td class="auto-style9">
    <asp:Button ID="sediste30" runat="server" Text="30" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste31" runat="server" Text="31" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste32" runat="server" Text="32" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste33" runat="server" Text="33" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                               <td class="auto-style9">
    <asp:Button ID="sediste34" runat="server" Text="34" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste35" runat="server" Text="35" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste36" runat="server" Text="36" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste37" runat="server" Text="37" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                               <td class="auto-style9">
    <asp:Button ID="sediste38" runat="server" Text="38" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste39" runat="server" Text="39" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste40" runat="server" Text="40" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste41" runat="server" Text="41" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                               <td class="auto-style9">
    <asp:Button ID="sediste42" runat="server" Text="42" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste43" runat="server" Text="43" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste44" runat="server" Text="44" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste45" runat="server" Text="45" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                               <td class="auto-style9">
    <asp:Button ID="sediste46" runat="server" Text="46" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste47" runat="server" Text="47" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste48" runat="server" Text="48" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste49" runat="server" Text="49" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
            <tr>
                                                <td class="auto-style9">
    <asp:Button ID="sediste50" runat="server" Text="50" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style10">
    <asp:Button ID="sediste51" runat="server" Text="51" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td class="auto-style8">&nbsp;</td>
<td class="auto-style10">
    <asp:Button ID="sediste52" runat="server" Text="52" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
<td>
    <asp:Button ID="sediste53" runat="server" Text="53" Width="30px" BackColor="Green" ForeColor="White" UseSubmitBehavior="False" OnClick="Button_Click"/>
</td>
            </tr>
        </table>

    </div>
    
    <table class="auto-style7">
        <tr>
            <td>Broj sedista:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td>
                <asp:TextBox ID="TextBoxBrSedista" runat="server" Width="158px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Ime i Prezime:</td>
            <td>
                <asp:TextBox ID="TextBoxIme" runat="server" Width="158px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td>
                <asp:TextBox ID="TextBoxEmail" runat="server" Width="158px"></asp:TextBox>
            </td>
        </tr>
    </table>
    
    <asp:Button ID="posalji" runat="server" Text="Posalji" Width="117px" OnClick="posalji_Click" />
    
</form>

</body>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

</html>
