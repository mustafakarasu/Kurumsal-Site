<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="IcerikDuzenle.aspx.cs" Inherits="WebApplication3.IcerikDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>İçerik düzenleme formu</h1>

    <div class="satir">
        <label>Başlık:</label> <input name="baslik" value="<%=icerik.Baslik %>"/>
    </div>
    <div class="satir">
        <label>Makale:</label> 
        <textarea name="makale" id="editor"  class="uzunyazi">
            <%=icerik.Makale %>
        </textarea>
    </div>
    <div class="satir">
        <input type="submit" value="KAYDET"/>
    </div>
</asp:Content>
