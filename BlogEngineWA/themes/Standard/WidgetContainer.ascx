<%@ Control Language="C#" AutoEventWireup="true" Inherits="BlogEngineWA.CustomCode.Controls.WidgetContainer" %>
<div class="widget <%= Widget.Name.Replace(" ", String.Empty).ToLowerInvariant() %>"
    id="widget<%= Widget.WidgetId %>">
    <%= AdminLinks %>
    <% if (this.Widget.ShowTitle)
       { %>
    <h4>
        <%= Widget.Title%></h4>
    <% }
       else
       { %>
    <br />
    <% } %>
    <div class="content">
        <asp:PlaceHolder ID="phWidgetBody" runat="server"></asp:PlaceHolder>
    </div>
</div>
