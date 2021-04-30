<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="viewMember.aspx.cs" Inherits="Stock_Management_System.dash.viewMember" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div class="card mt-4 py-2" style="overflow: hidden">
        <div class="row border-bottom">
            <div class="col-lg-12" >
                <h3 class="px-3">Member Details</h3>
            </div>
        </div>
        <div class="row p-3">
        <div class="table-responsive">
        <asp:GridView ID="GridView1" CssClass="table table table-hover py-0 text-dark mt-3" runat="server">

        </asp:GridView>
            </div>
    </div>
         </div>
</asp:Content>
