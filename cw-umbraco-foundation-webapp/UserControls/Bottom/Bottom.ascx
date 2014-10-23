<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Bottom_Bottom" Codebehind="Bottom.ascx.cs" %>
<%@ Register Src="~/UserControls/Bottom/FooterLinks.ascx" TagPrefix="uc1" TagName="FooterLinks" %>

<div class="row-fluid">
    <div class="span12">
        <uc1:FooterLinks runat="server" ID="FooterLinks" />
    </div>
</div>
<div class="row-fluid">
    <div class="span12">
        <umbraco:Item runat="server" Field="copyrightMessage"/>
    </div>
</div>