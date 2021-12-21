<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="New_Assignment.report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Page</title>
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
        <div>
            <h1>ReportPage</h1>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="AssetID" HeaderText="Asset Id" />
                <asp:BoundField DataField="AssetName" HeaderText="Asset" />
                <asp:BoundField DataField="VendorName" HeaderText="Vendor" />
                <asp:BoundField DataField="PurchaseDate" HeaderText="Purchase Date" />
                <asp:BoundField DataField="Cost" HeaderText="Cost" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Total Cost"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Text='<%# Eval("Cost")%>'"></asp:Label>
    </form>
</body>
</html>
