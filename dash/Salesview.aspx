<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesview.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Stock_Management_System.dash.Salesview" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="card mt-4 py-2" style="overflow: hidden">
        <div class="row border-bottom">
            <div class="col-lg-12 d-flex flex-row justify-content-between">
                <h3 class="px-3">Sales Details</h3>
                <div class="d-flex flex-row p-1 ">
                        <div class="form-group">
                            <asp:DropDownList ID="customer" runat="server" CssClass="form-select"></asp:DropDownList>
                        </div>
                <asp:Button Text="Search" CssClass="btn btn-success mx-1" runat="server" Height="40px" ID="Searchbtn" OnClick="Searchbtn_Click" />
            </div>
            </div>
        </div>
        <div class="row p-3">
        <div class="table-responsive">
        <asp:GridView ID="GridView1" CssClass="table py-0 text-dark mt-3" runat="server" AllowPaging="true">

        </asp:GridView>
            </div>
    </div>
         </div>
</asp:Content>
