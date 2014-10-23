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
    public class FooterLinksGetter : LinksExtractorBase, IFooterLinksGetter
    {
        public FooterLinksCollection GetLinks(int FooterLinksNodeId)
        {
            FooterLinksCollection collection = new FooterLinksCollection();

            // Get the Footer Links item
            var node = new Node(FooterLinksNodeId);

            string section1LinksString = node.GetProperty("section1FooterLinks").Value;
            string section2LinksString = node.GetProperty("section2FooterLinks").Value;
            string section3LinksString = node.GetProperty("section3FooterLinks").Value;
            string section4LinksString = node.GetProperty("section4FooterLinks").Value;

            collection.Section1Links = ExtractLinksFromXml(section1LinksString);
            collection.Section2Links = ExtractLinksFromXml(section2LinksString);
            collection.Section3Links = ExtractLinksFromXml(section3LinksString); 
            collection.Section4Links = ExtractLinksFromXml(section4LinksString);

            return collection;
        }

        
    }
}
