<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="EnglishMockExam.aspx.cs" Inherits="LEC_PSD.Views.MockExam.EnglishMockExam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p></p>
    <h1 style="width: 648px; margin-left: 47px">Bahasa Inggris</h1>
    <h1 style="width: 648px; margin-left: 47px;">Mock Exam</h1>
    <br />
    <h3 style="width: 910px; margin-left: 160px">*Exam ini dapat dikerjakan dari tanggal 01/01/2023 sampai 30/12/2023</h3>
    <br />
    <h3 style="width: 910px; margin-left: 160px">*Durasi Exam : 60 Menit</h3>
    <br />
    <h3 style="width: 910px; margin-left: 160px">*Exam Content : </h3>
    <h3 style="width: 910px; margin-left: 225px">* 10 Pertanyaan Pilihan Ganda</h3>
    <h3 style="width: 910px; margin-left: 226px">* 5 Pertanyaan Essai</h3>
    <h3 style="width: 910px; margin-left: 225px">* 1 pertanyaan Case</h3>
    <br />
    <p></p>
    <a>Nama Siswa   :<asp:Label ID="Eng_Mock_Username" runat="server" Text="Guest"></asp:Label></a>
    <br />
    <a>Kelas        :<asp:Label ID="Eng_Guest_Kelas" runat="server" Text="-"></asp:Label><asp:Label ID="Eng_Guest_Major" runat="server" Text="-"></asp:Label></a>
    <br />
    <a>Kode Exam    :<asp:Label ID="Eng_kode_exam" runat="server" Text="Unidentified"></asp:Label></a>
    <br />
    <a>Status       :<asp:Label ID="Eng_Status_Exam" runat="server" Text="Not Started"></asp:Label></a>
    <br />
    <br />
    <p></p>
    <h1>Video Rekomendasi</h1>
    <br />
    <asp:ImageButton ID="Eng_Vid_Recommend1" runat="server" ImageUrl="~/Images/Book Icon.jpg" Height="200px" Width="300px" style="margin-left: 151px"/>
    <asp:ImageButton ID="Eng_Vid_Recommend2" runat="server" ImageUrl="~/Images/Book Icon.jpg" Height="200px" Width="300px" style="margin-left: 150px"/>
    <asp:ImageButton ID="Eng_Vid_Recommend3" runat="server" ImageUrl="~/Images/Book Icon.jpg" Height="200px" Width="300px" style="margin-left: 150px"/>
    <br />
    <br />
    <p></p>
    <asp:Button ID="Eng_Forum" runat="server" Text="Forum" Height="70px" style="margin-left: 445px" Width="180px" />
    <asp:Button ID="Eng_Exam_Start" runat="server" Text="Start Exam" OnClick="Eng_Exam_Start_Click" Height="75px" style="margin-left: 250px" Width="180px"/>
</asp:Content>
