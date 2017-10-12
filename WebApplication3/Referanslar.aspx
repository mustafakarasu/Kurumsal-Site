<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.Master" AutoEventWireup="true" CodeBehind="Referanslar.aspx.cs" Inherits="WebApplication3.Referanslar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="ReferansEkle.aspx">Referans Ekle</a>

    <h1>Referanslar</h1>
    <p>Referanslar burada olacak.</p>

    <ul class="liste">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li><span><%#Eval("AdSoyad") %></span>
                    <a href="ReferansSil.aspx?ID=<%#Eval("ReferansID") %>">Sil</a>
                    <a href="ReferansEkle.aspx?ID=<%#Eval("ReferansID") %>">Düzenle</a>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
