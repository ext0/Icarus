using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Icarus.Node
{
    public class Node
    {
        public IPAddress Address;
        public short Port;
        public byte[] PublicKey;
        public List<Node> ConnectedNodes;
        public NodeType NodeType;
        public Node(IPAddress Address, short Port, NodeType NodeType, byte[] PublicKey = null, List<Node> ConnectedNodes = null)
        {
            this.Address = Address;
            this.Port = Port;
            this.NodeType = NodeType;
            this.PublicKey = PublicKey;
            this.ConnectedNodes = (ConnectedNodes == null) ? new List<Node>() : ConnectedNodes;
        }

        public override bool Equals(object obj)
        {
            if (obj is Node)
            {
                return (obj as Node).Address.Equals(Address) && (obj as Node).Port.Equals(Port);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Address.GetHashCode() ^ Port.GetHashCode();
        }
    }
}
