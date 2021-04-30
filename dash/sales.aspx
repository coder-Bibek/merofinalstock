﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="Stock_Management_System.dash.sales" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mt-4 py-2" style="overflow: hidden">
        <div class="row border-bottom">
            <div class="col-lg-12 px-4 py-1 pb-2">
                <div class="d-flex justify-content-between align-content-center">
                    <h3>Add Sales</h3>
                    <a class="btn btn-light" href="addmember.aspx">Add Member</a>
                </div>
            </div>
        </div>
        <div class="row p-3">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6 col-sm-12">
                        <div class="form-group">
                            <div class="form-label text-muted">Customer</div>
                            <asp:DropDownList ID="customer" runat="server" CssClass="form-select"></asp:DropDownList>
                        </div>
                        <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Required" ControlToValidate="customer" runat="server" />
                    </div>
                    <div class="col-md-6 col-sm-12">
                        <div class="form-group">
                            <div class="form-label text-muted">Product</div>
                            <asp:DropDownList ID="product" runat="server" CssClass="form-select"></asp:DropDownList>
                        </div>
                         <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Required" ControlToValidate="product" runat="server" />
                    </div>
                    <div class="col-sm-12 mb-3">
                        <div class="form-group">
                            <div class="form-label text-muted">Sales Name</div>
                            <asp:TextBox ID="salesName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                         <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Required" ControlToValidate="salesName" runat="server" />
                    </div>
                    <div class="col-md-6 col-sm-12 mb-3">
                        <div class="form-group">
                            <div class="form-label text-muted">Quantity</div>
                            <asp:TextBox ID="quantity" runat="server" type="number" class="form-control"></asp:TextBox>
                        </div>
                         <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Required" ControlToValidate="quantity" runat="server" />
                    </div>
                     <div class="alert alert-primary text-center alert-dismissible fade show mt-4" id="salesbox"  role="alert" runat="server">
                     </div>
                    <div class="d-inline">
                        <asp:Button ID="addSales" runat="server" Text="Add Sales" CssClass="btn btn-primary" OnClick="addSales_Click" />
                        <asp:Button ID="cancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
