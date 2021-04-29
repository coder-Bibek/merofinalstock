<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="profile.aspx.cs" Inherits="Stock_Management_System.dash.profile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mt-4 py-2" style="overflow: hidden">
        <div class="row border-bottom">
            <div class="col-lg-12">
                <h3 class="px-3">Profile</h3>
            </div>
        </div>
        <div class="row p-3">
            <div class="col-lg-6 col-md-6 col-sm-12 px-4">
                <div class="card border-0 shadow-sm px-4">
                    <div class="card-body">
                        <div class="row mb-3 text-center d-flex justify-content-center">
                            <div class="col-md-12 card shadow-sm p-2 d-inline text-center border-0" style="width: 5rem">
                                <i class="fas fa-user fa-4x" style="color: #333a56"></i>
                            </div>
                        </div>
                        <div class="row text-start">
                            <div class="col-sm-12 col-md-6 text-muted mb-3">
                                Name: <span class="text-dark font-weight-bold" id="nameTxt" runat="server"></span>
                            </div>
                            <div class="col-sm-12 col-md-6 text-muted mb-3 text-end">
                                Username: <span class="text-dark font-weight-bold" id="UsernameTxt" runat="server"></span>
                            </div>
                            <div class="col-sm-12 col-md-6 text-muted mb-3 ">
                                Email: <span class="text-dark font-weight-bold" id="emailTxt" runat="server"></span>
                            </div>
                            <div class="col-sm-12 col-md-6 text-muted mb-3 text-end">
                                Phone: <span class="text-dark font-weight-bold" id="phoneTxt" runat="server"></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-6 col-md-6 col-sm-12">
                <div class="card border-0 shadow-sm p-0">
                    <div class="card-body p-0">
                        <h5 class="card-title py-3 px-4 border-bottom">Change Password</h5>
                        <div class="py-3 px-4">
                            <div class="form-group mb-3">
                                <asp:TextBox CssClass="form-control" runat="server" placeholder="Current Password" ID="crntPwd"></asp:TextBox>
                            </div>
                            <div class="form-group mb-3">
                                <asp:TextBox CssClass="form-control" runat="server" placeholder="New Password" ID="newPwd"></asp:TextBox>
                            </div>
                            <div class="form-group mb-3">
                                <asp:TextBox CssClass="form-control" runat="server" placeholder="Confirm Password" ID="conPwd"></asp:TextBox>
                            </div>
                            <div class="alert alert-danger text-center alert-dismissible fade show mt-4" id="alertbox" role="alert" runat="server">
                            </div>
                            <div class="d-grid">
                              <%--  <asp:button class="btn btn-primary btn-block">Change</asp:button>--%>
                                <asp:Button Text="Change" CssClass="btn btn-primary btn-block" runat="server" ID="Changepwdbtn" OnClick="Changepwdbtn_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
