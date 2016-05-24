<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SCREEN.aspx.cs" Inherits="PresentationLayer.SCREEN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 26%;
            border-color: #999999;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style3 {
            width: 177px;
        }
    </style>
</head>
<body style="width: 1760px">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1"border="1
            " align="center">
            <tr>
                <td colspan="3">
                    <h1 class="auto-style2"><em>CRUD OPERATIONS</em></h1>
                </td>
            </tr>
            <tr>
                <td>SNO</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnCreate" runat="server" OnClick="BtnCreate_Click" Text="Create" />
                </td>
            </tr>
            <tr>
                <td>CAR NAME</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnRetrieve" runat="server" Text="Retrieve" />
                </td>
            </tr>
            <tr>
                <td>CAR MODEL</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
                </td>
            </tr>
            <tr>
                <td>CAR PRICE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
