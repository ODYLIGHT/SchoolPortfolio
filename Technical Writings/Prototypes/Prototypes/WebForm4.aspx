<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Prototypes.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" Height="50px" Width="637px" BorderStyle="Solid">
    <asp:TableRow>
        <asp:TableCell><h3>Form Name</h3></asp:TableCell>
        <asp:TableCell><h3>Status</h3></asp:TableCell>
        <asp:TableCell><h3>Member</h3></asp:TableCell>
    </asp:TableRow>

    <asp:TableRow>
        <asp:TableCell>Form 1</asp:TableCell>
        <asp:TableCell>Approved</asp:TableCell>
        <asp:TableCell>UserName 1</asp:TableCell>
    </asp:TableRow>
                
                    <asp:TableRow>
        <asp:TableCell>Form 2</asp:TableCell>
        <asp:TableCell>Processing</asp:TableCell>
        <asp:TableCell>UserName 3</asp:TableCell>
    </asp:TableRow>
                    <asp:TableRow>
        <asp:TableCell>Form 3</asp:TableCell>
        <asp:TableCell>Approved</asp:TableCell>
        <asp:TableCell>UserName 4</asp:TableCell>
    </asp:TableRow>
                    <asp:TableRow>
        <asp:TableCell>Form 4</asp:TableCell>
        <asp:TableCell>Not Approved</asp:TableCell>
        <asp:TableCell>UserName 2</asp:TableCell>
    </asp:TableRow>
                    <asp:TableRow>
        <asp:TableCell>Form 5</asp:TableCell>
        <asp:TableCell>Not Approved</asp:TableCell>
        <asp:TableCell>UserName 5</asp:TableCell>
    </asp:TableRow>

       </asp:Table>
        </div>
    </form>
</body>
</html>
