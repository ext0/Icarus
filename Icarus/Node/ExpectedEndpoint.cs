using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Icarus.Node
{
    public class ExpectedEndpoint : Node
    {
        public ExpectedEndpoint(IPAddress Address, short Port, byte[] PublicKey = null, List<Node> ConnectedNodes = null) 
            : base(Address, Port, NodeType.ENDPOINT, PublicKey, ConnectedNodes)
        {

        }
    }
}
