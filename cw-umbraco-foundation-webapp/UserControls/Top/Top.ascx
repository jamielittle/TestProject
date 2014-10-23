<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Top_Top" Codebehind="Top.ascx.cs" %>
<%@ Register Src="~/UserControls/Top/HeaderNavigation.ascx" TagPrefix="uc1" TagName="HeaderNavigation" %>

<div class="row">
    <div class="col-md-4"><umbraco:Image runat="server" Field="companyLogo"/></div>
    <div class="col-md-8">[RHS Header Content]</div>
</div>
<div class="row">
    <div class="col-md-4 col-md-offset-8">
        <uc1:HeaderNavigation runat="server" ID="HeaderNavigation" />
    </div>
</div>