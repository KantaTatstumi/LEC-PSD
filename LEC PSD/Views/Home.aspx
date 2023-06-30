<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LEC_PSD.Views.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Selamat Datang <asp:Label ID="Label_username" runat="server" Text="Guest"></asp:Label>,</h2>
    <h2 style="width: 454px; margin-left: 0px; margin-top: 0px">Kelas <asp:Label ID="Guest_Kelas" runat="server" Text="-"></asp:Label><asp:Label ID="Guest_Major" runat="server" Text="-"></asp:Label></h2>
            <br />
            <asp:ImageButton ID="Search_Button2" ImageUrl="~/Images/Search_Button.png" runat="server" OnClientClick="javascript:return confirm('are you sure you want to search?'" OnClick="Search_Button2_Click" Height="44px" style="margin-left: 71px" Width="75px"/>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="855px"></asp:TextBox>
            <br />
           <%-- <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/banner1.png" Height="405px" style="margin-top: 23px" Width="1262px"/>--%>
            <br />
            <br />
            <h1>Video Based Learning</h1>
            <br />
            <div></div>
            <a id="Indo_Label"><asp:ImageButton ID="Indo" runat="server" ImageUrl="~/Images/dictionary_indo.png" OnClick="Indo_Click"/>Indonesia</a>
            <a id="English_Label"><asp:ImageButton ID="English" runat="server" ImageUrl="~/Images/dictionary_eng.png" style="margin-left: 300px" OnClick="English_Click"/>English</a>
            <a id="Mandarin_Label"><asp:ImageButton ID="Mandarin" runat="server" ImageUrl="~/Images/dictionary_mandarin.png" style="margin-left: 300px" OnClick="Mandarin_Click"/>Mandarin</a>
            <a id="Math_Label"><asp:ImageButton ID="Math" runat="server" ImageUrl="~/Images/calc_math.png" style="margin-left: 291px" OnClick="Math_Click"/>Math</a>
            <a id="Multimedia_Label"><asp:ImageButton ID="Multimedia" runat="server" ImageUrl="~/Images/Multimedia.png" style="margin-left: 377px" OnClick="Multimedia_Click"/>Multimedia</a>
            <a id="Physics_Label"><asp:ImageButton ID="Phsyics" runat="server" ImageUrl="~/Images/Physics.png" style="margin-left: 609px" OnClick="Phsyics_Click"/>Physics</a>
            <br />
        </div>
       
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <br />
        <br />
        <h1>Rekomendasi</h1>
        <asp:ImageButton ID="Recommend1" runat="server" ImageUrl="~/Images/UTBK BANK SOAL 1.png" style="margin-left: 152px" OnClick="Recommend1_Click"/>
        <asp:ImageButton ID="Recommend2" runat="server" ImageUrl="~/Images/UTBK BANK SOAL 2.png" style="margin-left: 165px" OnClick="Recommend2_Click"/>
        <asp:ImageButton ID="Recommend3" runat="server" ImageUrl="~/Images/UTBK BANK SOAL 1.png" style="margin-left: 152px" OnClick="Recommend3_Click"/>
        <p></p>
        <asp:ImageButton ID="Recommend4" runat="server" ImageUrl="~/Images/UTBK BANK SOAL 2.png" style="margin-left: 148px" OnClick="Recommend4_Click"/>
        <asp:ImageButton ID="Recommend5" runat="server" ImageUrl="~/Images/UTBK BANK SOAL 2.png" style="margin-left: 167px" OnClick="Recommend5_Click"/>
        <asp:ImageButton ID="Recommend6" runat="server" ImageUrl="~/Images/UTBK BANK SOAL 2.png" style="margin-left: 156px" OnClick="Recommend6_Click"/>
    </form>
</body>
</html>
