<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registerscreen.aspx.cs" Inherits="Stock_Management_System.Screens.Registerscreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Management System</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../loginscreen.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link href="assets/images/logo.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form runat="server">
        <div class="container main-container">
            <div class="card p-3 mb-2 w-100 mx-1" style="width: 25rem; background-color: #333a56; box-shadow: 0px 0px 10px">
                <div class="card-body">
                    <div class="d-flex justify-content-center flex-row align-items-center" style="padding-bottom: 20px">
                        <h4 style="margin-top: -10px; margin-left: 5px; color: white; font-family: sans-serif">REGISTER</h4>
                    </div>
                    <div class="d-flex align-content-center flex-row">
                        <i class="fa fa-user" style="color: white"></i>
                        <p class="form-label" style="color: white; margin-top: -3px; margin-left: 5px; font-size: .875rem">Full Name</p>
                    </div>
                    <asp:TextBox  cssClass="form-control" ID="txtName" placeholder="eg. John Walker" runat="server" ></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" style="color:red" ErrorMessage="Required" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                    <div class="d-flex align-content-center flex-row mt-1">
                        <i class="fa fa-user" style="color: white"></i>
                        <p class="form-label" style="color: white; margin-top: -3px; margin-left: 5px; font-size: .875rem">Email</p>
                    </div>
                    <asp:TextBox  cssClass="form-control" ID="txtEmail" placeholder="example@example.com" TextMode="Email" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" style="color:red" ErrorMessage="Required" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    <div class="d-flex align-content-center flex-row mt-1">
                        <i class="fa fa-phone" aria-hidden="true" style="color: white"></i>
                        <p class="form-label" style="color: white; margin-top: -3px; margin-left: 5px; font-size: .875rem">Phone Number</p>
                    </div>
                    <asp:TextBox  cssClass="form-control" ID="txtNumber" placeholder="XXXXXXXXXX" TextMode="Number" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" style="color:red" ErrorMessage="Required" ControlToValidate="txtNumber"></asp:RequiredFieldValidator>
                    <div class="d-flex align-items-center flex-row  ">
                        <i class="fa fa-lock" style="color: white"></i>
                        <p class="form-label " style="color: white; margin-left: 5px; margin-top: 6px; font-size: .875rem" >Password</p>
                    </div>
                    <asp:TextBox cssClass="form-control" ID="txtPassword" placeholder="password" TextMode="Password" runat="server" />
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" style="color:red" ErrorMessage="Required" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    
                    <asp:Button Text="Register" CssClass="btn w-100  text-white" Style="background-color: #5e6ea7" runat="server" ID="Btnregister" OnClick="Btnregister_Click" />
                   <div class="alert alert-danger text-center alert-dismissible fade show mt-3 w-100 justify-content-center font-weight-bolder" id="alertbox" role="alert" runat="server">
                              
             </div>
                   <%-- <button class="btn w-100 my-4" style="margin-top: 20px !important; background-color: #5e6ea7; color: white" runat="server">Register</button--%>
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
                    Already have an account? <a href="Loginscreen.aspx">Login</a></label>
            </div>
            </div>
    </form>
</body>
</html>
