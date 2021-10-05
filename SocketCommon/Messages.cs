using System;

namespace SocketCommon
{
    public class Messages {
        public const string MSG_NEW_SERVER_STARTING = "NSS ";
        public const string MSG_SERVER_LEAVING = "SRVL";
        public const string MSG_KNOWN_SERVERS = "SRVK";
        public const string MSG_YOU_ALIVE = "YOUA";
        public const string MSG_ALIVE = "ALIV";
        public const string MSG_SERVER_DEAD = "DEAD";
        public const string MSG_ROLE_REBALANCING = "ROLE";
        public const string MSG_SERVER_STATS = "STAT";

        public const byte MINIMUM_MESSAGE_LENGTH = 4;

    }
}
