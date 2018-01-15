<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Calendar.aspx.cs" Inherits="Calendar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Calendar ID="Calendar1" runat="server" Height="563px" ShowGridLines="True" SelectionMode="None" TodayDayStyle-ForeColor="Red" SelectedDate="<%# DateTime.Today %>" NextPrevFormat="FullMonth" Style="margin-top: 0px" Width="775px" BackColor="#FFFF99" OnDayRender="Calendar1_DayRender" SelectWeekText="" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged">
        <DayHeaderStyle BackColor="Yellow" />
        <TitleStyle BorderColor="#660033" BorderStyle="Solid" />
        <WeekendDayStyle BackColor="Tan" Font-Bold="true" />
        <OtherMonthDayStyle ForeColor="SlateGray"></OtherMonthDayStyle>
        <TitleStyle Font-Bold="true" />
        <DayStyle Font-Bold="true" />
    </asp:Calendar>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server" Visible="False">

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>

