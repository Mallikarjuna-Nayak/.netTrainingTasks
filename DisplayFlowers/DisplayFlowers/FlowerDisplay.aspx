<%@ Page Title="Display Flowers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="DisplayFlowers.Contact" %>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.DataBind();
    }
</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Display selected Flowers.</h3>
    

    
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatColumns="2" size="3">
        <asp:ListItem Selected="True">Jasmine</asp:ListItem>
        <asp:ListItem>Rose</asp:ListItem>
        <asp:ListItem>Lotus</asp:ListItem>
        <asp:ListItem>Lilly</asp:ListItem>
        <asp:ListItem>Hibiscus Red</asp:ListItem>
        <asp:ListItem>Sunflower</asp:ListItem>
    </asp:RadioButtonList>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="<%# RadioButtonList1.SelectedItem.Text %>"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
