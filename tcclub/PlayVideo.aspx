<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlayVideo.aspx.cs" Inherits="PlayVideo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="height:500px;width:780px;overflow:scroll;">
        <asp:Repeater ID="RepeaterImagesV" runat="server">
            <ItemTemplate>
                <asp:Image ID="Image" runat="server" ImageUrl='<%# Container.DataItem %>' style="width: 372px"/>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

