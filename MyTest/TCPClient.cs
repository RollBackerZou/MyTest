using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    public class TCPClient
    {
        TcpClient tc = new TcpClient("",2222);
        NetworkStream ns = tc.GetStream();
    }
}
