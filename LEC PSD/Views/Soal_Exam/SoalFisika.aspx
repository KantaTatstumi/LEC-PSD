<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="SoalFisika.aspx.cs" Inherits="LEC_PSD.Views.Soal_Exam.SoalFisika" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p></p>
    <asp:Label ID="Fisika_Soal1" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_1_1" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_1"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_1_2" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_1"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_1_3" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_1"/>
    </div>
    <asp:Button ID="Submit_Fisika_1" runat="server" Text="Submit" OnClick="Submit_Fisika_1_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Fisika_Soal2" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_2_1" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_2"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_2_2" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_2"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_2_3" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_2"/>
    </div>
    <asp:Button ID="Submit_Fisika_2" runat="server" Text="Submit" OnClick="Submit_Fisika_2_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Fisika_Soal3" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_3_1" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_3"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_3_2" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_3"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_3_3" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_3"/>
    </div>
    <asp:Button ID="Submit_Fisika_3" runat="server" Text="Submit" OnClick="Submit_Fisika_3_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Fisika_Soal4" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_4_1" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_4"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_4_2" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_4"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_4_3" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_4"/>
    </div>
    <asp:Button ID="Submit_Fisika_4" runat="server" Text="Submit" OnClick="Submit_Fisika_4_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Fisika_Soal5" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_5_1" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_5"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_5_2" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_5"/>
    <br />
    <asp:RadioButton ID="Fisika_jwb_Option_5_3" runat="server" Visible="true" GroupName="Fisika_Jwb_Option_5"/>
    </div>
    <asp:Button ID="Submit_Fisika_5" runat="server" Text="Submit" OnClick="Submit_Fisika_5_Click"/>

    <p>
        <asp:Button ID="Fisika_Finish_exam" runat="server" Text="Finish Exam" OnClick="Fisika_Finish_exam_Click"/>
    </p>
</asp:Content>
