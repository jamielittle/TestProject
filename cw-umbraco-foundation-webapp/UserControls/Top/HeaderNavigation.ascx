<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Top_HeaderNavigation" Codebehind="HeaderNavigation.ascx.cs" %>
<%@ Import Namespace="Entities" %>
<div class="navbar navbar-static-top navbar yamm">
    <div class="">
        <button class="navbar-toggle navbar-inverse" data-toggle="collapse" data-target=".navHeaderCollapse" onclick="return false;">
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
        </button>
        <div class="collapse navbar-collapse navHeaderCollapse">
            <asp:Repeater runat="server" ID="rptHeaderMenu">
                <HeaderTemplate>
                    <ul class="nav navbar-nav">
                </HeaderTemplate>
                <ItemTemplate>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#"><%# ((Entities.MenuItem)Container.DataItem).ItemText %></a>
                        <ul class="dropdown-menu">
                            <li class="yamm-content">
                                <div class="row">
                                    <div class="col-md-12"><%# ((Entities.MenuItem)Container.DataItem).MenuHeader %></div>
                                    <div class="col-md-6">
                                        <asp:Repeater runat="server" ID="rptItems" DataSource="<%# ((Entities.MenuItem)Container.DataItem).Links %>">
                                            <HeaderTemplate><ul></HeaderTemplate>
                                            <ItemTemplate>
                                                <li><a href="<%# ((UrlLink)(Container.DataItem)).LinkUrl %>"><%# ((UrlLink)(Container.DataItem)).Title %></a></li>
                                            </ItemTemplate>
                                            <FooterTemplate></ul></FooterTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</div>