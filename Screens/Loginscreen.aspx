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
    <div class="container main-container">
        <div class="card p-3 mb-2 w-100 mx-1" style="width: 25rem; background-color: #333a56; box-shadow: 0px 0px 10px">
            <div class="card-body">
                <div class="d-flex justify-content-center flex-row align-items-center" style="padding-bottom: 20px">
                    <h4 style="margin-top: -10px; margin-left: 5px; color: white; font-family: sans-serif">MERO <span class="text-danger"> Stock Management</span></h4>
                </div>
                <div class="d-flex align-content-center flex-row">
                    <i class="fa fa-user" style="color: white"></i>
                    <p class="form-label" style="color: white; margin-top:-2px;font-size:.875rem; margin-left: 5px">Email</p>
                </div>
                <input type="email" class="form-control" placeholder="email" required="required" />
                <div class="d-flex align-items-center flex-row">
                    <i class="fa fa-lock mt-2" style="color: white"></i>
                    <p class="form-label " style="color: white; margin-left: 5px;font-size:.875rem; margin-top:18px;font-family:sans-serif">Password</p>
                </div>
                <input type="password" class="form-control" placeholder="password" required="required" />
                <button class="btn w-100 my-4" style="margin-top: 30px !important;background-color: #5e6ea7;color:white" id="liveToastBtn" onclick="Mylogin()" disabled>Login</button>
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
    <div class="position-fixed bottom-0 end-0 p-3" style="z-index:3">
        <div id="liveToast" class="toast hide bg-danger" data-delay="2000" data-animation:"true" style="height: 3rem;transition:opacity 0.1s ease-out" role="alert" aria-live="assertive" aria-atomic="true">
            <div class="toast-header bg-danger">
                <label class="me-auto" style="color: white; font-weight: bold; font-size: 18px">!Invalid username/password</label>
                <button type="button" class="btn-close"  data-bs-dismiss="toast" aria-label="Close"></button>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function Mylogin() {
            $("#liveToast").toast('show')
        }
    </script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>
