<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DummyWebform._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h3>Error Log</h3>
            <asp:Button ID="btnException" runat="server" OnClick="btnException_Click" Text="Throw Exception" />
        </div>        
    </div>

</asp:Content>
