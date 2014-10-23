<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Bottom.ascx.cs" Inherits="UserControls_Bottom_Bottom" %>
<%@ Register Src="~/UserControls/Bottom/FooterLinks.ascx" TagPrefix="uc1" TagName="FooterLinks" %>

<div class="row-fluid">
    <div class="span12">
        <uc1:FooterLinks runat="server" ID="FooterLinks" />
    </div>
</div>