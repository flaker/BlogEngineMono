<%@ Control Language="C#" AutoEventWireup="true" Inherits="BlogEngineWA.widgets.Calendar.Widget" Codebehind="widget.ascx.cs" %>
<div style="text-align: center">
    <blog:PostCalendar ID="PostCalendar1" runat="Server" NextMonthText=">>" DayNameFormat="FirstTwoLetters"
        FirstDayOfWeek="monday" PrevMonthText="<<" CssClass="calendar" BorderWidth="0"
        WeekendDayStyle-CssClass="weekend" OtherMonthDayStyle-CssClass="other" UseAccessibleHeader="true"
        EnableViewState="false" />
    <br />
    <a href="<%=Utils.AbsoluteWebRoot %>calendar/default.aspx">View posts in large calendar</a>
</div>
