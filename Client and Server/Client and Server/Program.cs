using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_and_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("127.0.01", 4444);
            server.Start();
            server.Stop();
        }
    }
}
