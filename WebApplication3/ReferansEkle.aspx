<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="ReferansEkle.aspx.cs" Inherits="WebApplication3.ReferansEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Referans <%=ekle ? "ekleme" : "düzenleme" %> formu</h1>

    <div class="satir">
        <label>Ad Soyad:</label> <input name="adsoyad" value="<%=r.AdSoyad %>"/>
    </div>

    <div class="satir">
        <label>Mesaj</label> <input name="mesaj" class="uzunyazi" value="<%=r.Mesaj %>"/>
    </div>

    <input type="submit" value="KAYDET"/>
</asp:Content>
