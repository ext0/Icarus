using Icarus.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus.Node
{
    public static class NodeMap
    {
        public static bool ValidRoute(NodeRoute Path)
        {
            for (int i = 0; i <= Path.Route.Count; i++)
            {
                if (Path.Route[i].ConnectedNodes.Where((x) =>
                {
                    return x.Equals(Path.Route[i + 1]);
                }).Count() == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
