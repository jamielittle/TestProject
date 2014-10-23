using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Interfaces.DatabaseAbstractionLayer;
using Umbraco.Core.Dynamics;
using umbraco.NodeFactory;

namespace DatabaseAbstractionLayer.Umbraco
{
    public class HeaderLinksGetter : LinksExtractorBase, IHeaderLinksGetter
    {
        public List<MenuItem> GetMenuItems(int HeaderLinksNodeId)
        {
            var headLinksNode = new Node(HeaderLinksNodeId);
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (Node headerSection in headLinksNode.Children)
            {
                MenuItem menuItem = new MenuItem();

                menuItem.ItemText = headerSection.GetProperty("itemText").Value;
                menuItem.MenuHeader = headerSection.GetProperty("menuHeader").Value;
                menuItem.Links = base.ExtractLinksFromXml(headerSection.GetProperty("menuLinks").Value);

                menuItems.Add(menuItem);
            }

            return menuItems;
        }
    }
}
