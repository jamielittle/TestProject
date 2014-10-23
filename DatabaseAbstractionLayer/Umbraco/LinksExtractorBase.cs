using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Umbraco.Core.Dynamics;

namespace DatabaseAbstractionLayer.Umbraco
{
    public class LinksExtractorBase
    {
        public List<UrlLink> ExtractLinksFromXml(string linksString)
        {
            List<UrlLink> links = new List<UrlLink>();
            DynamicXml section1 = new DynamicXml(linksString.Replace("-", ""));


            foreach (dynamic item in section1)
            {
                links.Add(new UrlLink()
                {
                    LinkUrl = (item.mode == "Content") ? umbraco.library.NiceUrl(int.Parse(item.nodeid)) : item.url,
                    LinkTarget = (item.newwindow == ("True")) ? " target=\"_blank\"" : string.Empty,
                    Title = item.linktitle,
                });
            }

            return links;
        }
    }
}
