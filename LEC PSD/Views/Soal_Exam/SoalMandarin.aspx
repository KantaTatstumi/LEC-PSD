<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="SoalMandarin.aspx.cs" Inherits="LEC_PSD.Views.Soal_Exam.SoalMandarin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p></p>
    <asp:Label ID="Mandarin_Soal1" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_1_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_1_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_1_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Mandarin_1" runat="server" Text="Submit" OnClick="Submit_Mandarin_1_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Mandarin_Soal2" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_2_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_2_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_2_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Mandarin_2" runat="server" Text="Submit" OnClick="Submit_Mandarin_2_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Mandarin_Soal3" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_3_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_3_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_3_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Mandarin_3" runat="server" Text="Submit" OnClick="Submit_Mandarin_3_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Mandarin_Soal4" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_4_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_4_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_4_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Mandarin_4" runat="server" Text="Submit" OnClick="Submit_Mandarin_4_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Mandarin_Soal5" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_5_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_5_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Mandarin_jwb_Option_5_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Mandarin_5" runat="server" Text="Submit" OnClick="Submit_Mandarin_5_Click"/>

    <p>
        <asp:Button ID="Mandarin_Finish_exam" runat="server" Text="Finish Exam" OnClick="Mandarin_Finish_exam_Click"/>
    </p>
</asp:Content>
