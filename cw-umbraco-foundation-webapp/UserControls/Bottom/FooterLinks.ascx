<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="FooterLinks.ascx.cs" Inherits="UserControls_Bottom_FooterLinks" %>
<%@ Import Namespace="Entities" %>
<div class="row">
    <div class="col-md-3">
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
        <div class="col-md-3">
        <asp:Repeater runat="server" ID="rptContainer2">
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
    <div class="col-md-3">
        <asp:Repeater runat="server" ID="rptContainer3">
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
    <div class="col-md-3">
        <asp:Repeater runat="server" ID="rptContainer4">
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
</div>