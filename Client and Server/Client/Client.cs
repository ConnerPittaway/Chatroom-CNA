using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Packets;

namespace Client
{
    public class Client
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private BinaryWriter writer;
        private BinaryReader reader;
        private BinaryFormatter formatter;
        private ClientForm clientForm;


        public Client()
        {
            tcpClient = new TcpClient();
            //clientForm = new ClientForm(this);
            //clientForm.ShowDialog();
        }

        public bool Connect(string ipAddress, int port)
        {
            try
            {
                tcpClient.Connect(ipAddress, port);
                stream = tcpClient.GetStream();
                reader = new BinaryReader(stream, Encoding.UTF8);
                writer = new BinaryWriter(stream, Encoding.UTF8);
                formatter = new BinaryFormatter();
                return true;
            }
            catch
            {
                Console.WriteLine("Exception: ");
                return false;
            }
        }

        public void Run()
        {
            //string userInput;
            //ProcessServerResponse();
            //Console.Write("Enter data: ");
            //while((userInput = Console.ReadLine()) != null)
            //{
            //    writer.WriteLine(userInput);
            //    writer.Flush();
            //    ProcessServerResponse();
            //    Console.Write("Enter data: ");
            //}
            clientForm = new ClientForm(this);
            Thread responseThread = new Thread(() => { ProcessServerResponse(); });
            responseThread.Start();
            clientForm.ShowDialog();
        }

        private void ProcessServerResponse()
        {
            while (reader != null)
            {
                int numberOfBytes;
                //return reader.ReadLine();
                if ((numberOfBytes = reader.ReadInt32()) != -1)
                    {
                        byte[] buffer = reader.ReadBytes(numberOfBytes);
                        MemoryStream mStream = new MemoryStream(buffer);
                        Packet clientPacket = formatter.Deserialize(mStream) as Packet;

                    switch (clientPacket.packetType)
                    {
                        case PacketType.ChatMessage:
                            {
                                ChatMessagePacket chatPacket = clientPacket as ChatMessagePacket;
                                clientForm.UpdateChatWindow(chatPacket.m_message);
                                break;
                            }
                        case PacketType.ClientName:
                            {
                                NicknamePacket nicknamePacket = clientPacket as NicknamePacket;
                                clientForm.UpdateClientList(nicknamePacket.m_message);
                                break;
                            }
                        case PacketType.PrivateMessage:
                            {
                                PrivatePacket privatePacket = clientPacket as PrivatePacket;
                                clientForm.SendPrivateMessage(privatePacket.m_message);
                                break;
                            }
                        case PacketType.RockGame:
                            {
                                RockPacket rockPacket = clientPacket as RockPacket;
                                clientForm.SendRockMessage(rockPacket.m_message);
                                break;
                            }
                    }
                }



            }


        }

        public void SendMessage(Packet message)
        {
                MemoryStream mStream = new MemoryStream();
                formatter.Serialize(mStream, message);
                byte[] buffer = mStream.GetBuffer();
                writer.Write(buffer.Length);
                writer.Write(buffer);
                //writer.WriteLine(message);
                writer.Flush();
        }
    }
}
