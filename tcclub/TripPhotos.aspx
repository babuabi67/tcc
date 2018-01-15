<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TripPhotos.aspx.cs" Inherits="Photos" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:550px;width:780px;overflow:scroll;">
        <asp:Repeater ID="RepeaterImagesT" runat="server">
            <ItemTemplate>
                <asp:Image ID="Image" runat="server" ImageUrl='<%# Container.DataItem %>' style="width: 372px"/>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <img id="Img1" src="../Images/4.jpg" alt="" runat="server" class="imgLeft" />
    <p>
    SURAT, India — The immense popularity of Narendra Modi, India’s most dynamic prime minister in decades, has always rested on two legs: Hindu nationalism and his tantalizing promises to build on the country’s go-go economy. That second leg is now looking a little shaky. In the last two years, India’s consumer confidence has plummeted, construction has slowed, the fixed investment rate has fallen, many factories have shut down, and unemployment has gone up. Fingers are pointing at Modi. Just about all economists agree that two of the prime minister’s biggest policy gambles — abruptly voiding most of the nation’s currency and then, less than a year later, imposing a sweeping new sales tax </p>

</asp:Content>