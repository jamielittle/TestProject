using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Entities;
using Umbraco.Core;
using Umbraco.Core.Dynamics;
using umbraco.NodeFactory;
using Umbraco.Web;
using Umbraco.Web.Routing;
using umbraco.cms.businesslogic.language;

public partial class UserControls_Bottom_FooterLinks : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the Footer Links item
        int FooterLinksId = 1058;
        var node = new Node(FooterLinksId);
        
        string linksString = node.GetProperty("section1FooterLinks").Value;
        DynamicXml section1 = new DynamicXml(linksString);

        List<UrlLink> links = new List<UrlLink>();

        foreach (dynamic item in section1)
        {
            links.Add(new UrlLink()
                {
                    LinkUrl = (item.type.Equals("internal")) ? umbraco.library.NiceUrl(int.Parse(item.link)) : item.link,
                    LinkTarget = (item.newwindow.Equals("1")) ? " target=\"_blank\"" : string.Empty,
                    Title = item.title,
                });
            
        }

        rptContainer1.DataSource = links;
        rptContainer1.DataBind();
    }

}