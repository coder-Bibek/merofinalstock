<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="addProduct.aspx.cs" Inherits="Stock_Management_System.dash.addProduct" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mt-4 py-2" style="overflow: hidden">
        <div class="row border-bottom">
            <div class="col-lg-12 px-4 py-1 pb-2">
                <div class="d-flex justify-content-between align-content-center">
                    <h3>Add Product</h3>
                    <button type="button" class="btn btn-light" data-bs-toggle="modal" data-bs-target="#myModal">Add Category</button>
                </div>
            </div>
        </div>
        <div class="row p-3">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6 col-sm-12">
                        <div class="form-group">
                            <div class="form-label text-muted">Item Name</div>
                            <asp:TextBox ID="itemName" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-danger" ErrorMessage="Required" ControlToValidate="itemName"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12 mb-1">
                        <div class="form-group">
                            <div class="form-label text-muted">Price</div>
                            <asp:TextBox ID="price" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="text-danger" ErrorMessage="Required" ControlToValidate="price"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-sm-12 mb-1">
                        <div class="form-group">
                            <div class="form-label text-muted">Description</div>
                            <asp:TextBox ID="description" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="text-danger" ErrorMessage="Required" ControlToValidate="description"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12">
                        <div class="form-group">
                            <div class="form-label text-muted">Purchase Date</div>
                            <asp:TextBox ID="purcahseDate" runat="server" class="form-control" type="date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="text-danger" ErrorMessage="Required" ControlToValidate="purcahseDate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12 mb-1">
                        <div class="form-group">
                            <div class="form-label text-muted">Category</div>
                            <asp:DropDownList ID="category" runat="server" CssClass="form-select"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" CssClass="text-danger" ErrorMessage="Required" ControlToValidate="category"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12">
                        <div class="form-group">
                            <div class="form-label text-muted">Manufacture Date</div>
                            <asp:TextBox ID="manufactureDate" runat="server" class="form-control" type="date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" CssClass="text-danger" ErrorMessage="Required" ControlToValidate="manufactureDate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-12 mb-1">
                        <div class="form-group">
                            <div class="form-label text-muted">Expiry Date</div>
                            <asp:TextBox ID="expiryDate" runat="server" class="form-control" type="date"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-12 mb-1">
                        <div class="alert alert-danger text-center alert-dismissible fade show mt-4" id="alertbox" role="alert" runat="server">
                        </div>
                    </div>
                    <div class="d-inline">
                        <asp:Button ID="addProduct" runat="server" Text="Add Product" CssClass="btn btn-primary" OnClick="addProduct_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="myModal" tabindex="-1" aria-labelledby="myModal" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Add category</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <div class="form-label text-muted">Category Name</div>
                        <asp:TextBox ID="categoryName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                    <asp:Button ID="addCaterogyButton" runat="server" Text="Add " CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>

    <script>
        var myModal = document.getElementById('myModal')
        var myInput = document.getElementById('categoryName')

        myModal.addEventListener('shown.bs.modal', function () {
            myInput.focus()
        })
    </script>

</asp:Content>
