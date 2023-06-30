<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="SoalMultimedia.aspx.cs" Inherits="LEC_PSD.Views.Soal_Exam.SoalMultimedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p></p>
    <asp:Label ID="Multimedia_Soal1" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_1_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_1_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_1_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Multimedia_1" runat="server" Text="Submit" OnClick="Submit_Multimedia_1_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Multimedia_Soal2" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_2_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_2_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_2_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Multimedia_2" runat="server" Text="Submit" OnClick="Submit_Multimedia_2_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Multimedia_Soal3" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_3_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_3_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_3_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Multimedia_3" runat="server" Text="Submit" OnClick="Submit_Multimedia_3_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Multimedia_Soal4" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_4_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_4_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_4_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Multimedia_4" runat="server" Text="Submit" OnClick="Submit_Multimedia_4_Click"/>

    <div>
        <p></p>
    <asp:Label ID="Multimedia_Soal5" runat="server" Text="Label" Visible="true"></asp:Label>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_5_1" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_5_2" runat="server" Visible="true"/>
    <br />
    <asp:RadioButton ID="Multimedia_jwb_Option_5_3" runat="server" Visible="true"/>
    </div>
    <asp:Button ID="Submit_Multimedia_5" runat="server" Text="Submit" OnClick="Submit_Multimedia_5_Click"/>

    <p>
        <asp:Button ID="Multimedia_Finish_exam" runat="server" Text="Finish Exam" OnClick="Multimedia_Finish_exam_Click"/>
    </p>
</asp:Content>
