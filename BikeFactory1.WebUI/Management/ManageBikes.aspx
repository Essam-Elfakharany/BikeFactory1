<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageBikes.aspx.cs" Inherits="BikeFactory1.WebUI.Management.ManageBikes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bike Manager</title>
    <link href="../lib/bootstrap/css/bootstrap.css" rel="stylesheet" /> 
    <link href="../Style.css" rel="stylesheet" />
    <script src="../lib/bootstrap/js/bootstrap.js"></script>

    <style>
        .addUpdateBtn {
            width :100%;
            margin:5px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <h2>Manage Bike</h2>
            <asp:LinkButton ID="lkbSignOut" Text="(Click here to sign out)" CausesValidation="false" runat="server" OnClientClick="return btnLogOutConfirmClick();" OnClick="lkbSignOut_Click"></asp:LinkButton>
        </div>
         <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <asp:Label Text="Name:" AssociatedControlID="txtName" runat="server"></asp:Label>
                    <asp:RequiredFieldValidator Display="Dynamic" ErrorMessage="Name is required" ControlToValidate="txtName" runat="server" />
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label Text="Suspension Type:" AssociatedControlID="ddlSuspensionType" runat="server"></asp:Label>
                    <asp:CustomValidator ID="cvSuspensionType" Display="Dynamic" ErrorMessage="Suspension Type is required" runat="server" OnServerValidate="cvSuspensionType_ServerValidate" />
                    <asp:DropDownList ID="ddlSuspensionType" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Undefined"></asp:ListItem>
                        <asp:ListItem Text="Front" Value="Front"></asp:ListItem>
                        <asp:ListItem Text="Rear" Value="Rear"></asp:ListItem>
                        <asp:ListItem Text="Dual" Value="Dual"></asp:ListItem>
                    </asp:DropDownList>

                    <asp:Label Text="TireType:" AssociatedControlID="ddlTireType" runat="server"></asp:Label>
                    <asp:CustomValidator ID="cvTireType" Display="Dynamic" ErrorMessage="Tire Type is required" runat="server" OnServerValidate="cvTireType_ServerValidate" />
                    <asp:DropDownList ID="ddlTireType" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Undefined"></asp:ListItem>
                        <asp:ListItem Text="Regular"></asp:ListItem>
                        <asp:ListItem Text="Commuter"></asp:ListItem>
                        <asp:ListItem Text="Gravel"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div class="row">
                        <div class="col-sm-6">
                            <asp:Button ID="btnAdd" Text="Add" CausesValidation="true" runat="server" CssClass="btn btn-primary addUpdateBtn" OnClick="btnAdd_Click" />
                        </div>
                        <div class="col-sm-6">
                            <asp:Button ID="btnUpdate" Text="Update" CausesValidation="true" runat="server" CssClass="btn btn-primary addUpdateBtn" OnClick="btnUpdate_Click" />
                        </div>
                    </div>
                </div>

                <div class="col-md-6">
                    <asp:DataGrid ID="dgBikes" Width="100%" CssClass="hoverable" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="dgBikes_SelectedIndexChanged">
                        <Columns>
                            <asp:ButtonColumn CommandName="Select" Text="Select"></asp:ButtonColumn>
                            <asp:BoundColumn DataField="Id" HeaderText="Id"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Name" HeaderText="Name"></asp:BoundColumn>                            
                            <asp:BoundColumn DataField="SuspensionType" HeaderText="Suspension<br/>Type"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TireType" HeaderText="Tire<br/>Type"></asp:BoundColumn>
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <ItemStyle BackColor="White" ForeColor="#003399" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" Mode="NumericPages" />
                        <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" Font-Italic="False" />
                    </asp:DataGrid>

                    <br />
                     <div class="row">

                        <asp:Button ID="btnRemove" Text="Remove Selected Bike" CausesValidation="false" runat="server" CssClass="btn btn-danger col-6" OnClick="btnRemove_Click" OnClientClick="return btnRemoveClientClick();" />
                    </div>
                </div>
            </div>
                    </div>

    </form>
     <script>
        function btnRemoveClientClick() {
            if (!confirm("Do you confirm this deletion?"))
                return false;

            return true;
        }
        function btnLogOutConfirmClick() {
            if (!confirm("Do you want to sign out?"))
                return false;

            return true;
        }
    </script>
</body>
</html>
