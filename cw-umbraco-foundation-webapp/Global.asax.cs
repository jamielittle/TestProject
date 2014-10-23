using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using StructureMap;

namespace cw_umbraco_foundation
{
    public class Global : Umbraco.Web.UmbracoApplication
    {
        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            base.OnApplicationStarting(sender, e);
            ObjectFactory.Initialize( x => x.AddRegistry(new IoCRegistry()));
        }
    }
}