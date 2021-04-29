<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginscreen.aspx.cs" Inherits="Stock_Management_System.Screens.Loginscreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Management System</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../loginscreen.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form runat="server">
        <div class="container main-container">
            <div class="card p-3 mb-2 w-100 mx-1" style="width: 25rem; background-color: #333a56; box-shadow: 0px 0px 10px">
                <div class="card-body">
                    <div class="d-flex justify-content-center flex-row align-items-center" style="padding-bottom: 1.25rem">
                        <h4 class="mb-3 text-white font-weight-bolder">MERO <span class="text-danger font-weight-bolder">STOCK</span></h4>
                    </div>
                    <div class="d-flex align-content-center flex-row">
                        <i class="fa fa-user" style="color: white"></i>
                        <p class="form-label" style="color: white; margin-top: -2px; font-size: .875rem; margin-left: 5px">Email</p>
                    </div>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="w-100 form-control" placeholder="email" />
                    <div class="d-flex align-items-center flex-row">
                        <i class="fa fa-lock mt-2" style="color: white"></i>
                        <p class="form-label " style="color: white; margin-left: 5px; font-size: .875rem; margin-top: 18px; font-family: sans-serif">Password</p>
                    </div>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="w-100 form-control" placeholder="password" />
                    <%--  <button class="btn w-100 my-4" style="margin-top: 30px !important;background-color: #5e6ea7;color:white" id="liveToastBtn" onclick="Mylogin()" disabled>Login</button>--%>
                    <asp:Button Text="Login" CssClass="btn w-100 mt-4" Style="background-color: #5e6ea7" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
                    <div class="alert alert-danger text-center alert-dismissible fade show mt-4" id="alertbox" role="alert" runat="server">
                        <strong>Invalid Email/Password</strong>
                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                    </div>
                </div>
            </div>
            <div class="d-flex justify-content-center">
                <label
                    style="margin-top: 10px !important; color: white; font-family: sans-serif; font-size: 0.8rem;">
                    &copy;Stock Management System. All Rights Reserved</label>
            </div>
            <div class="d-flex justify-content-center">
                <label
                    style="margin-top: 10px !important; color: white; font-family: sans-serif; font-size: 0.8rem;">
                    Create a New Account? <a href="Registerscreen.aspx">Register Here</a></label>
            </div>
        </div>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
