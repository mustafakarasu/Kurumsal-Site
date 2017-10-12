<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="Icerikler.aspx.cs" Inherits="WebApplication3.Icerikler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="IcerikEkle.aspx">İçerik Ekle</a>

    <h1>İçerikler</h1>
    <p>İçeriklerin listesi burada olacak.</p>

    <ul class="liste">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                    <span><%#Eval("Baslik") %></span> 
                    <a href="IcerikSil.aspx?ID=<%#Eval("IcerikID") %>">Sil</a>
                    <a href="IcerikDuzenle.aspx?ID=<%#Eval("IcerikID") %>">Düzenle</a>
                </li> <!-- Bir tane bıraktık şablon olarak-->
            </ItemTemplate>
        </asp:Repeater> 
    </ul>

</asp:Content>
