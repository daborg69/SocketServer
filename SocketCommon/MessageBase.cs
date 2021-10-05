using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketCommon
{
    public class MessageBase
    {
        public string Code { get; init; }
        public string IPFrom { get; init; }

        public Object Data { get; init; }

        public MessageBase (string code, string ipFrom, object data = null) {
            Code = code;
            ipFrom = ipFrom;
            Data = data;
        }




        public static string GetLocalIPAddress () {
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                // TODO - this needs to be fixed somehow - maybe connect to local gateway...
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }
    }
}
