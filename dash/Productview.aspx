<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Productview.aspx.cs" Inherits="Stock_Management_System.dash.Productview" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div class="card mt-4 py-2" style="overflow: hidden">
        <div class="row border-bottom">
            <div class="col-lg-12 d-flex flex-row justify-content-between">
                <h3 class="px-3">Product Details</h3>
                <div class="d-flex flex-row p-1 ">
                   
                        <div class="form-group">
                            <asp:DropDownList ID="item" runat="server" CssClass="form-select"></asp:DropDownList>
                        </div>
                <asp:Button Text="Search" CssClass="btn btn-success mx-1" runat="server" Height="40px" ID="Searchbtn" OnClick="Searchbtn_Click" />
            </div>
            </div>
        </div>
        <div class="row p-3">
        <div class="table-responsive">
        <asp:GridView ID="GridView1" CssClass="table py-0 text-dark mt-3" runat="server">

        </asp:GridView>
            <div class="d-flex justify-content-end">
             <button  data-bs-toggle="modal" type="button" data-bs-target="#staticBackdrop" Class="btn btn-danger mx-1 " >Delete all</button>
            </div>
            </div>
    </div>
         </div>
   <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="staticBackdropLabel">Product Details</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        <p class="modal-body">Do You want to delete all stocks?</p>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
          <asp:Button Text="Delete" CssClass="btn btn-danger" runat="server" ID="Deletebtn" OnClick="Deletebtn_Click"/>
      </div>
    </div>
  </div>
</div>
    <script type="text/javascript">
        var myModal = document.getElementById('myModal')
        var focuon = document.getElementById('staticBackdropLabel')
        myModal.addEventListener('shown.bs.modal', function () {
            focuon.focus();
        }    
            )
    </script>
</asp:Content>
