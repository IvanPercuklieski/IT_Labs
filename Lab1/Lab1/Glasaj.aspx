<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab1.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-4 m-2">
            <asp:Image ID="Image1" runat="server" ImageUrl="https://www.finki.ukim.mk/sites/default/files/styles/large/public/default_images/finki_52_1_2_1_62_0.png?itok=miZDgQ_6" />
            <br /><asp:Label ID="prof" runat="server" Text="Professor Name"></asp:Label><br />
            <asp:ListBox ID="subject" runat="server" AutoPostBack="True" OnSelectedIndexChanged="subject_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="credits" runat="server" AutoPostBack="True" OnSelectedIndexChanged="credits_SelectedIndexChanged"></asp:ListBox><br />
            <asp:Button ID="Button1" runat="server" Text="Vote" OnClick="Button1_Click" />
        </div>
    </div>

    <div class="row">
        <div class="col-3 m-2">
            <br />Subject:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            Credits:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
        </div>
    </div>

</asp:Content>
