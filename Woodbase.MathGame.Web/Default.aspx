<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Standard.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Woodbase.MathGame.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphGameArea" runat="server">
    <asp:Literal runat="server" ID="litQuestion" />
    <asp:Panel runat="server" ID="pnlSuggestions"></asp:Panel>
</asp:Content>
