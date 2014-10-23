<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FooterLinks.ascx.cs" Inherits="UserControls_Bottom_FooterLinks" %>
<%@ Import Namespace="System.ComponentModel" %>
<div class="row-fluid">
    <div class="span3">
        <asp:Repeater runat="server" ID="rptContainer1">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li><a href="<%# ((UrlLink)(Container.DataItem)).LinkUrl %>"><%# ((UrlLink)(Container.DataItem)).Title %></a></li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </div>
        <div class="span3">
        <ul>
            <li><a href="#">Link 1</a></li>
            <li><a href="#">Link 2</a></li>
            <li><a href="#">Link 3</a></li>
            <li><a href="#">Link 4</a></li>
        </ul>
    </div>
    <div class="span3">
        <ul>
            <li><a href="#">Link 1</a></li>
            <li><a href="#">Link 2</a></li>
            <li><a href="#">Link 3</a></li>
            <li><a href="#">Link 4</a></li>
        </ul>
    </div>
    <div class="span3">
        <ul>
            <li><a href="#">Link 1</a></li>
            <li><a href="#">Link 2</a></li>
            <li><a href="#">Link 3</a></li>
            <li><a href="#">Link 4</a></li>
        </ul>
    </div>
</div>