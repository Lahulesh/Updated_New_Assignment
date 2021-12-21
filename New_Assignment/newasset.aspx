<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newasset.aspx.cs" Inherits="New_Assignment.newasset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Asset</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12 text-center">
                <h4>SOCIETY BILLING SOFTWARE</h4>
            </div>
        </div>
    </div>
    <nav class="navbar navbar-expand-lg navbar-light bg-light ">
        <div class="container">
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link" aria-current="page" href="Home.aspx">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="vendor.aspx">Vendors</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="assetlist.aspx">Asset List</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="newasset.aspx">New Asset</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="report.aspx">Report</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <h1>New Asset Forms</h1>
        <asp:Label ID="Label1" runat="server" Text="Asset ID"></asp:Label>
        <asp:TextBox ID="newassetid" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Asset Name"></asp:Label>
        <asp:TextBox ID="newassetname" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label3" runat="server" Text="Vendor Name"></asp:Label>
        <asp:DropDownList ID="DropDownList1" DataValueField="VendorName" runat="server">
            <asp:ListItem>Please Select The Vendor Name</asp:ListItem>
        </asp:DropDownList><br />
        <%--<asp:TextBox ID="newassetvendor" runat="server"></asp:TextBox><br />--%>

        <asp:Label ID="Label4" runat="server" Text="Purchase Date"></asp:Label>
        <asp:TextBox ID="newassetpurchase" runat="server" type="date"></asp:TextBox><br />

        <asp:Label ID="Label5" runat="server" Text="Cost"></asp:Label>
        <asp:TextBox ID="newassetcost" runat="server"></asp:TextBox><br />

        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label6" runat="server"></asp:Label>
    </form>
</body>
</html>
