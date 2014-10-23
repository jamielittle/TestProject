using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cw_umbraco_foundation_webapp.UserControls
{
    public class MacroBase : System.Web.UI.UserControl
    {
        public string SiteRoot { get; set; }
        public string DataSource { get; set; }
        public int DataSourceInt {
            get 
            { 
                int iReturn = 0;
                int.TryParse(DataSource, out iReturn);
                return iReturn;
            }
        }
    }
}