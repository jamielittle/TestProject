using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Interfaces.DatabaseAbstractionLayer
{
    public interface IHeaderLinksGetter
    {
        List<MenuItem> GetMenuItems(int HeaderLinksNodeId);
    }
}
