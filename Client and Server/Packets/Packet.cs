using System;

namespace Packets
{
    [Serializable]
    public class Packet
    {
        
        public PacketType packetType
        {
            get;
            protected set;
        } 
    }


    public enum PacketType
    {
        ChatMessage,
        PrivateMessage,
        ClientName,
        RockGame,
    };

    [Serializable]
    public class ChatMessagePacket : Packet
    {
        public string m_message;
        public ChatMessagePacket(string message)
        {
            m_message = message;
            packetType = PacketType.ChatMessage;
        }
    }

    [Serializable]
    public class NicknamePacket : Packet
    {
        public string m_message;
        public NicknamePacket(string message)
        {
            m_message = message;
            packetType = PacketType.ClientName;
        }
    }

    [Serializable]
    public class PrivatePacket : Packet
    {
        public string m_message;
        public PrivatePacket(string message)
        {
            m_message = message;
            packetType = PacketType.PrivateMessage;
        }
    }

    [Serializable]
    public class RockPacket : Packet
    {
        public string m_message;
        public RockPacket(string message)
        {
            m_message = message;
            packetType = PacketType.RockGame;
        }
    }

}
