<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Math.aspx.cs" Inherits="LEC_PSD.Views.Course.Math" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h1>Matematika Wajib dan Minat</h1>
     <h2 style="width: 454px; margin-left: 0px; margin-top: 0px">Kelas <asp:Label ID="Math_Kelas" runat="server" Text="-"></asp:Label><asp:Label ID="Math_Major" runat="server" Text="-"></asp:Label></h2>'
    <asp:Button ID="Math_Bank" runat="server" Text="Bank Soal" Height="56px" style="margin-left: 250px" Width="200px" OnClick="Math_Bank_Click"/>
    <asp:Button ID="Math_Mock" runat="server" Text="Mock Exam" Height="56px" style="margin-left: 250px" Width="201px" OnClick="Math_Mock_Click"/>
    <br />
    <%--<p></p>
    <asp:Button ID="Math_Bab" runat="server" Text="Bab" Height="46px" style="margin-left: 608px" Width="155px" />
    <asp:Button ID="Math_Materi" runat="server" Text="Materi" Height="46px" Width="155px" />
    <br />--%>
    <p></p>
    <h2>Semua Bab</h2>
    <asp:Button ID="Math_Bab1" runat="server" Text="Trigonometri" Height="56px" style="margin-left: 61px" Width="200px" />
    <asp:Button ID="Math_Bab2" runat="server" Text="Kalkulus" Height="56px" style="margin-left: 201px" Width="201px" />
    <asp:Button ID="Math_Bab3" runat="server" Text="Algebra" Height="56px" style="margin-left: 200px" Width="200px" />
    <asp:Button ID="Math_Bab4" runat="server" Text="Complex Calculation" Height="56px" style="margin-left: 462px" Width="201px" />
</asp:Content>
