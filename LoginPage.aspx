<%@ Page Language="vb"  AutoEventWireup="false" CodeBehind="LoginPage.aspx.vb" Inherits="ResultsCompiler.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/Login.css" rel="stylesheet" type="text/css" />
    <title></title>
    
    <style type="text/css">
        #TextArea1
        {
            height: 35px;
            width: 318px;
        }
    </style>
    
    </head>
    
<body class = "Body">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
    <div class ="page">
    <div  class = "head">
    </div>
    <div class ="Sep">&nbsp;</div>
    <div class = "center" align="center">
    
        <div class  = "area">
       
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table style="width:100%;">
                        <tr>
                            <td align="center" colspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                User Name:</td>
                            <td align="left">
                                <asp:TextBox ID="txtUser" runat="server" Width="154px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                Password:</td>
                            <td align="left">
                                <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="155px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td align="left">
                                <asp:Button ID="btnLogin" runat="server" Font-Names="Haettenschweiler" 
                                    Font-Size="Medium" ForeColor="#FF9933" Height="27px" Text="Login" 
                                    Width="86px" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
       
    </div>
      <div class ="Sep">&nbsp;</div>
    </div>
    </form>
   
</body>
</html>
