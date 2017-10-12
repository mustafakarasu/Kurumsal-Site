<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bizeulasin.aspx.cs" Inherits="WebApplication3.bizeulasin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>İletişim formu</h1>

    <p><%=sonuc %></p>

    <div class="satir">
        <label>Ad Soyad:</label> <input name="AdSoyad" placeholder="Ad Soyad giriniz."/>
    </div>
    <div class="satir">
        <label>Telefon:</label> <input name="Telefon" placeholder="05xx"/>
    </div>
    <div class="satir">
        <label>Mesajınız:</label> <textarea name="mesaj"></textarea>
    </div>
    <div class="satir">
        <input type="submit" value="GÖNDER"/>
    </div>
</asp:Content>
