<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Top.ascx.cs" Inherits="UserControls_Top_Top" %>
<%@ Register Src="~/UserControls/Top/HeaderNavigation.ascx" TagPrefix="uc1" TagName="HeaderNavigation" %>

<div class="row-fluid">
    <div class="span4">[Logo]</div>
    <div class="span8">[RHS Header Content]</div>
</div>
<div class="row-fluid">
    <div class="span4 offset8">
        <uc1:HeaderNavigation runat="server" ID="HeaderNavigation" />
    </div>
</div>