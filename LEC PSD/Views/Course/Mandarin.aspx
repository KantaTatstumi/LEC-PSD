<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Mandarin.aspx.cs" Inherits="LEC_PSD.Views.Course.Mandarin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h1>Bahasa Mandarin</h1>
     <h2 style="width: 454px; margin-left: 0px; margin-top: 0px">Kelas <asp:Label ID="Mandarin_Kelas" runat="server" Text="-"></asp:Label><asp:Label ID="Mandarin_Major" runat="server" Text="-"></asp:Label></h2>'
    <asp:Button ID="mandarin_Bank" runat="server" Text="Bank Soal" Height="56px" style="margin-left: 250px" Width="200px" OnClick="mandarin_Bank_Click"/>
    <asp:Button ID="Mandarin_Mock" runat="server" Text="Mock Exam" Height="56px" style="margin-left: 250px" Width="201px" OnClick="Mandarin_Mock_Click"/>
    <br />
    <%--<p></p>
    <asp:Button ID="Mandarin_Bab" runat="server" Text="Bab" Height="46px" style="margin-left: 608px" Width="155px" />
    <asp:Button ID="Mandarin_Materi" runat="server" Text="Materi" Height="46px" Width="155px" />
    <br />--%>
    <p></p>
    <h2>Semua Bab</h2>
    <asp:Button ID="Mandarin_Bab1" runat="server" Text="Trigonometri" Height="56px" style="margin-left: 61px" Width="200px" />
    <asp:Button ID="Mandarin_Bab2" runat="server" Text="Kalkulus" Height="56px" style="margin-left: 201px" Width="201px" />
    <asp:Button ID="Mandarin_Bab3" runat="server" Text="Algebra" Height="56px" style="margin-left: 200px" Width="200px" />
    <asp:Button ID="Mandarin_Bab4" runat="server" Text="Complex Calculation" Height="56px" style="margin-left: 462px" Width="201px" />

     <p>
        <br />
        <asp:Button ID="Tambah_Soal_Mandarin" runat="server" Text="Tambah_Soal_Pelajaran" Height="56px" style="margin-left: 462px" Width="201px" Visible="false" OnClick="Tambah_Soal_Eng_Click"/>
    </p>

</asp:Content>
