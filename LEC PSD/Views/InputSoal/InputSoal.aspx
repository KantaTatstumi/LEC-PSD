<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="InputSoal.aspx.cs" Inherits="LEC_PSD.Views.InputSoal.InputSoal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Question Input Guide</h4>
    <h4>Question Id have 5 digit Ex : 10101</h4>
    <h4>Course Id have 3 digit Ex : 701</h4>
    <h4>to input question based on course, change first digit of question id with the first digit of Course Id or the Course Grade</h4>
    <h4>To input Next Question, iterate the question Id Ex : from 10101 to 10102</h4>
    <h4>Course Id no need to be changed except when changing course</h4>
    <p></p>
    <p>Question_Id<asp:TextBox ID="Question_Id" runat="server"></asp:TextBox></p>
    <p>Course_Id<asp:TextBox ID="Course_Id" runat="server"></asp:TextBox></p>
    <p>Question<asp:TextBox ID="Question" runat="server"></asp:TextBox></p>
    <asp:Button ID="Execute_1" runat="server" Text="Submit" OnClick="Execute_1_Click"/>
    <p></p>

    <h4>Answer Input Guide</h4>
    <h4>Question Id have 5 digit Ex : 10101</h4>
    <h4>Answer Id have 7 digit Ex : 7010101</h4>
    <h4>to input Answer based on course, change first digit of question id with the first digit of Course Id or the Course Grade</h4>
    <h4>To input Next Answer, iterate the question Id Ex : from 1010101 to 1010102 and follow question id last digit, last digit must same!</h4>
    <h4>Question Id : 10101 Must have same last digit with Answer Id : 1010101</h4>

    
        <p>Answer_Id<asp:TextBox ID="Answer_Id" runat="server"></asp:TextBox></p>
       <p>Question_Id<asp:TextBox ID="Answer_Qst_Id" runat="server"></asp:TextBox></p>
        <p>Answer<asp:TextBox ID="Answer" runat="server"></asp:TextBox></p>
        <p>Choice1<asp:TextBox ID="Choice1" runat="server"></asp:TextBox></p>
        <p>Choice2<asp:TextBox ID="Choice2" runat="server"></asp:TextBox></p>
        <p>Choice3<asp:TextBox ID="Choice3" runat="server"></asp:TextBox></p>
        <asp:Button ID="Execute_2" runat="server" Text="Submit" OnClick="Execute_2_Click"/>
</asp:Content>
