using Icarus.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    public class SocketWrapper
    {
        private ExpectedEndpoint Endpoint;
        public SocketWrapper(ExpectedEndpoint Endpoint)
        {
            this.Endpoint = Endpoint;
        }
        //hash path on return to verify
        public void Handshake()
        {

        }
    }
}
