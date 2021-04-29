<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesview.aspx.cs" Inherits="Stock_Management_System.dash.Salesview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" >

            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="sales_id" DataSourceID="SqlDataSource1" Height="260px" Width="500px">
                <Columns>
                    <asp:BoundField DataField="sales_id" HeaderText="sales_id" InsertVisible="False" ReadOnly="True" SortExpression="sales_id" />
                    <asp:BoundField DataField="sales_name" HeaderText="sales_name" SortExpression="sales_name" />
                    <asp:BoundField DataField="sales_date" HeaderText="sales_date" SortExpression="sales_date" />
                    <asp:BoundField DataField="inventory_id" HeaderText="inventory_id" SortExpression="inventory_id" />
                    <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                    <asp:BoundField DataField="user_id" HeaderText="user_id" SortExpression="user_id" />
                    <asp:BoundField DataField="cust_name" HeaderText="cust_name" SortExpression="cust_name" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mero_stockConnectionString %>" SelectCommand="SELECT * FROM [sales]"></asp:SqlDataSource>
      

        </div>
    </form>
</body>
</html>
