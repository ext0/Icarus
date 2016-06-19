using Icarus.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Icarus.Route
{
    public class NodeRoute
    {
        public ExpectedEndpoint Endpoint;
        public List<Node.Node> Route;
        public NodeRoute(List<Node.Node> Route)
        {
            this.Route = Route;
            this.Endpoint = (ExpectedEndpoint)Route[Route.Count - 1];
        }
    }
}
