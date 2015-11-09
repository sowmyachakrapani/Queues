<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GenericQueueCollection_Exp.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    counter1</td>
                <td>
                    &nbsp;</td>
                <td>
                    counter2</td>
                <td>
                    &nbsp;</td>
                <td>
                    counter3</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtCounter1" runat="server" BackColor="#003366" 
                        ForeColor="White"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="TxtCounter2" runat="server" BackColor="#003366" 
                        ForeColor="White" ontextchanged="TextBox2_TextChanged"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="TxtCounter3" runat="server" BackColor="#003366" 
                        ForeColor="White"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Next" onclick="Button1_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Next" onclick="Button2_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Next" onclick="Button3_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="TextBox4" runat="server" Width="848px" BackColor="#006600" 
                        ForeColor="White" Font-Bold="True"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:ListBox ID="ListTokens" runat="server"></asp:ListBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="PrintToken" runat="server" Text="PrintToken" 
                        onclick="Button4_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
              
                <td colspan="5">
                    <asp:Label ID="LblStatus" runat="server"></asp:Label>
                </td>
               
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
