using Interfaces.DatabaseAbstractionLayer;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class IoCRegistry : Registry
{
	public IoCRegistry()
	{
        For<IFooterLinksGetter>().Singleton().Use<DatabaseAbstractionLayer.Umbraco.FooterLinksGetter>();
	    For<IHeaderLinksGetter>().Singleton().Use<DatabaseAbstractionLayer.Umbraco.HeaderLinksGetter>();
	}
}