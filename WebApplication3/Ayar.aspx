<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="Ayar.aspx.cs" Inherits="WebApplication3.Ayar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Site Ayarları</h1>

    <div class="satir">
        <label>Logo</label> <input type="file" name="logo"/>
        <img src="<%=a.Logo %>" width="50" height="50"/>
    </div>

    <div class="satir">
        <label>Email</label> <input name="email" value="<%=a.MailAdres %>"/>
    </div>

     <div class="satir">
        <label>Copyright</label> <input name="copyright" value="<%=a.Copyright %>"/>
    </div>

     <div class="satir">
        <input type="submit" value="KAYDET"/>
    </div>
</asp:Content>
