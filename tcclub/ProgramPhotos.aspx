<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProgramPhotos.aspx.cs" Inherits="ProgramPhotos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick" Enabled="False">
            </asp:Timer>
            <asp:Image ID="Image1" runat="server" Width="770px" Height="500px" BorderStyle="Solid" />

  
            <div id="test" style="height:50px; width:770px; border:solid; background-color: floralwhite ">
                <asp:ImageButton ID="ImageButtonFirst" runat="server" OnClick="ImageButtonFirst_Click" Style="width: 50px; height: 50px" ImageAlign="left" BackColor="Beige" ImageUrl="~/Images/first.jpg" ToolTip="First" />
                <asp:ImageButton ID="ImageButtonStartStop" runat="server" OnClick="ImageButtonStartStop_Click" Style="width: 50px; height: 50px" ImageAlign="right" BackColor="Beige" ImageUrl="~/Images/start.jpg" />
                <asp:ImageButton ID="ImageButtonPrevious" runat="server" OnClick="ImageButtonPrevious_Click" Style="width: 50px; height: 50px" ImageAlign="left" BackColor="Beige" ImageUrl="~/Images/previous.png" Visible="True" ToolTip="Previous" />
                <asp:ImageButton ID="ImageButtonNext" runat="server" OnClick="ImageButtonNext_Click" Style="width: 50px; height: 50px" ImageAlign="left" BackColor="Beige" ImageUrl="~/Images/next.jpg" Visible="True" ToolTip="Next" />
                <asp:ImageButton ID="ImageButtonLast" runat="server" OnClick="ImageButtonLast_Click" Style="width: 50px; height: 50px" ImageAlign="left" BackColor="Beige" ImageUrl="~/Images/last.jpg" Visible="True" ToolTip="Last" />
                <asp:Label ID="Label1"  runat="server" Text="Label" CssClass="imgCenter" Font-Bold="True" ForeColor = "DarkSlateGray" Font-Names = "Verdana" Width="330px"></asp:Label>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <img id="Img1" src="../Images/1.jpg" alt="" runat="server" class="imgLeft" />
    <p>
        SURAT, India — The immense popularity of Narendra Modi, India’s most dynamic prime minister in decades, has always rested on two legs: Hindu nationalism and his tantalizing promises to build on the country’s go-go economy. That second leg is now looking a little shaky. In the last two years, India’s consumer confidence has plummeted, construction has slowed, the fixed investment rate has fallen, many factories have shut down, and unemployment has gone up. Fingers are pointing at Modi. Just about all economists agree that two of the prime minister’s biggest policy gambles — abruptly voiding most of the nation’s currency and then, less than a year later, imposing a sweeping new sales tax
    </p>

</asp:Content>

