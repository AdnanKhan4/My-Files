<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Webforms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <center>
    <form id="form1" runat="server">
        <div>
           ID:&nbsp &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtID" runat="server" Width="150px"></asp:TextBox>
        </div>
        <p>
           Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtName" runat="server" Width="150px"></asp:TextBox>
        </p>
        <p>
           Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtPhone" runat="server" Width="150px"></asp:TextBox>
        </p>
        <p>
           Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtEmail" runat="server" Width="150px"></asp:TextBox>
        </p>
        <p>
           Password:&nbsp;&nbsp; <asp:TextBox ID="TxtPassword" runat="server" Width="150px"></asp:TextBox>
        </p>
        <asp:Button ID="Btn_Submit" runat="server" Text="SUBMIT" BackColor="#006699" BorderColor="Gray" BorderStyle="Double" Font-Bold="True" Font-Overline="False" Font-Size="15px" Font-Strikeout="False" ForeColor="White" OnClick="Btn_Submit_Click" Width="100px" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="500px">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </form>
        </center>
</body>
</html>
