<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registerscreen.aspx.cs" Inherits="Stock_Management_System.Screens.Registerscreen" %>

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
     <div class="container main-container">
        <div class="card p-3 mb-2 w-100 mx-1" style="width: 25rem; background-color: #333a56; box-shadow: 0px 0px 10px">
            <div class="card-body">
                <div class="d-flex justify-content-center flex-row align-items-center" style="padding-bottom: 20px">
                    <h4 style="margin-top: -10px; margin-left: 5px; color: white; font-family: sans-serif">REGISTER</h4>
                </div>
                <div class="d-flex align-content-center flex-row">
                    <i class="fa fa-user" style="color: white"></i>
                    <p class="form-label" style="color: white; margin-top: -3px; margin-left: 5px;font-size:.875rem">Full Name</p>
                </div>
                   <input type="text" class="form-control" placeholder="eg. John Walker" />
                <div class="d-flex align-content-center flex-row mt-3">
                    <i class="fa fa-user" style="color: white"></i>
                    <p class="form-label" style="color: white; margin-top: -3px; margin-left: 5px;font-size:.875rem">Email</p>
                </div>
                <input type="email" class="form-control" placeholder="example@example.com" />
                <div class="d-flex align-content-center flex-row mt-3">
                    <i class="fa fa-phone" aria-hidden="true" style="color:white"></i>
                    <p class="form-label" style="color: white; margin-top: -3px; margin-left: 5px;font-size:.875rem">Phone Number</p>
                </div>
                <input type="text" class="form-control" placeholder="+977 XXXXXXXXXX" />
                <div class="d-flex align-items-center flex-row mt-2">
                    <i class="fa fa-lock" style="color: white"></i>
                    <p class="form-label " style="color: white; margin-left: 5px;margin-top:6px;font-size:.875rem">Password</p>
                </div>
                <input type="password" class="form-control" placeholder="password" />
              <button class="btn w-100 my-4" style="margin-top: 20px !important;background-color: #5e6ea7;color:white" id="liveToastBtn" onclick="Mylogin()" disabled>Register</button>
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
</body>
</html>
