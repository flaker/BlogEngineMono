<%@ Control Language="C#" AutoEventWireup="true" Inherits="BlogEngineWA.widgets.BlogRoll.Widget" Codebehind="widget.ascx.cs" %>
<%@ Register TagPrefix="blog" Namespace="BlogEngineWA.CustomCode.Controls" Assembly="BlogEngineWA"%>
<blog:Blogroll ID="Blogroll1" runat="server" />
<a href="<%=Utils.AbsoluteWebRoot %>opml.axd" style="display: block; text-align: right"
    title="Download OPML file">Download OPML file <img src="<%=Utils.AbsoluteWebRoot %>pics/opml.png"
        alt="OPML" /></a>