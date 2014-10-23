using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAbstractionLayer.Umbraco;
using Interfaces.DatabaseAbstractionLayer;
using StructureMap;
using cw_umbraco_foundation_webapp.UserControls;
using MenuItem = Entities.MenuItem;

public partial class UserControls_Top_HeaderNavigation : MacroBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IHeaderLinksGetter headerLinksGetter = ObjectFactory.GetInstance<IHeaderLinksGetter>();
        List<MenuItem> menuItems = headerLinksGetter.GetMenuItems(DataSourceInt);
        rptHeaderMenu.DataSource = menuItems;
        rptHeaderMenu.DataBind();
    }
}