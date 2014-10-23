using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Entities;
using Interfaces.DatabaseAbstractionLayer;
using Umbraco.Core;
using Umbraco.Core.Dynamics;
using Umbraco.Web;
using Umbraco.Web.Routing;
using umbraco.cms.businesslogic.language;
using umbraco.presentation.nodeFactory;
using StructureMap;

public partial class UserControls_Bottom_FooterLinks : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IFooterLinksGetter footerLinksGetter = ObjectFactory.GetInstance<IFooterLinksGetter>();
        FooterLinksCollection collection = footerLinksGetter.GetLinks();
        
        rptContainer1.DataSource = collection.Section1Links;
        rptContainer1.DataBind();

        rptContainer2.DataSource = collection.Section2Links;
        rptContainer2.DataBind();

        rptContainer3.DataSource = collection.Section3Links;
        rptContainer3.DataBind();

        rptContainer4.DataSource = collection.Section4Links;
        rptContainer4.DataBind();
    }

}