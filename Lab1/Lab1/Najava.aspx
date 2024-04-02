<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="Lab1.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-4">
            <div class="m-2">
                <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ViewStateMode="Inherit" EnableViewState="True"></asp:RequiredFieldValidator>
            </div>
            <div class="m-2">
                <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" ErrorMessage="RequiredFieldValidator" ViewStateMode="Enabled"></asp:RequiredFieldValidator>
            </div>
            <div class="m-2">
                <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator3" ControlToValidate="TextBox3" runat="server" ErrorMessage="RequiredFieldValidator" ViewStateMode="Enabled"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ForeColor="Red" ID="RegularExpressionValidator1" ControlToValidate="TextBox3" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="\S+\@\S+\.\S+" ValidateRequestMode="Enabled" ViewStateMode="Inherit"></asp:RegularExpressionValidator>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" />
            </div>
        </div>
    </div>

</asp:Content>
