<%@ Page Title="Add Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addmember.aspx.cs" Inherits="Stock_Management_System._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mt-4 py-2" style="overflow: hidden">
        <div class="row border-bottom">
            <div class="col-lg-12">
                <h3 class="px-3">Add Member</h3>
            </div>
        </div>
        <div class="row p-3">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6 col-sm-12">
                        <div class="form-group">
                            <div class="form-label text-muted">Name</div>
                            <asp:TextBox ID="customerName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12 mb-3">
                        <div class="form-group">
                            <div class="form-label text-muted">Address</div>
                            <asp:TextBox ID="address" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-12 mb-3">
                        <div class="form-group">
                            <div class="form-label text-muted">Email</div>
                            <asp:TextBox ID="Email" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12 ">
                        <div class="form-group">
                            <div class="form-label text-muted">Contact Number</div>
                            <asp:TextBox ID="contactNumber" runat="server" class="form-control" type="date"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12 mb-3">
                        <div class="form-group">
                            <div class="form-label text-muted">Member Type</div>
                            <asp:DropDownList ID="memberType" runat="server" CssClass="form-select"></asp:DropDownList>
                        </div>
                    </div>
                     <div class="col-sm-12 mb-1">
                        <div class="alert alert-danger text-center alert-dismissible fade show mt-4" id="alertbox" role="alert" runat="server">
                        </div>
                    </div>
                    
                    <div class="d-inline">
                        <asp:Button ID="addMember" runat="server" Text="Add Member" CssClass="btn btn-primary" OnClick="addMember_Click" />
                        <asp:Button ID="cancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
