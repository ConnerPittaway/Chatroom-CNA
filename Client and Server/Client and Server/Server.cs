using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Runtime.Serialization.Formatters.Binary;
using Packets;

namespace Client_and_Server
{
    class Server
    {
        private TcpListener tcpListener;
        private ConcurrentDictionary<int, Client> m_Clients;
        public Server(string ipAddress, int port)
        {
            tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
        }

        public void Start()
        {
            m_Clients = new ConcurrentDictionary<int, Client>();
            int ClientIndex = 0;
            tcpListener.Start();
            Console.WriteLine("Server Started...");
            while (true)
            {
                int CurrentClientIndex = ClientIndex;

                ClientIndex++;
                Socket socket = tcpListener.AcceptSocket();
                Console.WriteLine("Client Connected...");
                Client n_Client = new Client(socket);
                m_Clients.TryAdd(CurrentClientIndex, n_Client);
                Thread thread = new Thread(() => { ClientMethod(CurrentClientIndex); });
                m_Clients[CurrentClientIndex].SetNick("Default");
                m_Clients[CurrentClientIndex].SetRockChoice("");
                thread.Start();
            }
        }

        public void Stop()
        {
            tcpListener.Stop();
        }

        private void ClientMethod(int index)
        {
            Console.WriteLine("Client Method Started...");
            Packet recievedPacket;
            //client.Send(recievedMessage);
            while ((recievedPacket = m_Clients[index].Read()) != null)
            {
                switch(recievedPacket.packetType)
                {
                    case PacketType.ChatMessage:
                        {
                            ChatMessagePacket chatPacket = recievedPacket as ChatMessagePacket;
                            ChatMessagePacket outPacket = new ChatMessagePacket(m_Clients[index].GetNick() + ": " + chatPacket.m_message);
                            foreach (Client c in m_Clients.Values)
                            {
                                c.Send(outPacket);
                            }
                            break;
                        }
                    case PacketType.ClientName:
                        {
                            NicknamePacket nicknamePacket = recievedPacket as NicknamePacket;
                            m_Clients[index].SetNick(nicknamePacket.m_message);
                            break;
                        }
                    case PacketType.PrivateMessage:
                        {
                            PrivatePacket privatePacket = recievedPacket as PrivatePacket;
                            string cName = m_Clients[index].GetNick();
                            foreach (Client c in m_Clients.Values)
                            {
                                if (c.GetNick() == SearchMessage(privatePacket.m_message))
                                {
                                    privatePacket.m_message= (cName + ": " + privatePacket.m_message);
                                    c.Send(privatePacket);
                                }
                            }
                            break;
                        }
                    case PacketType.RockGame:
                        {
                            RockPacket rockPacket = recievedPacket as RockPacket;
                            RockPacket WinnerPacket = recievedPacket as RockPacket;
                            RockPacket LoserPacket = recievedPacket as RockPacket;
                            RockPacket ChallengeMessage = recievedPacket as RockPacket;
                            string cName = m_Clients[index].GetNick();
                            SearchGameMessage(rockPacket.m_message, m_Clients[index]);
                            foreach (Client c in m_Clients.Values)
                            {
                                if (c.GetNick() == SearchMessage(rockPacket.m_message))
                                {
                                    
                                    if(m_Clients[index].GetRockChoice() != "" && c.GetRockChoice() != "")
                                    {
                                        if(m_Clients[index].GetRockChoice() == c.GetRockChoice())
                                        {
                                            rockPacket.m_message = "You have the same choice so draw";
                                            m_Clients[index].SetRockChoice("");
                                            c.SetRockChoice("");
                                            m_Clients[index].Send(rockPacket);
                                            c.Send(rockPacket);
                                        }
                                        else if (m_Clients[index].GetRockChoice() == "Rock" &&  c.GetRockChoice() == "Paper")
                                        {
                                            WinnerPacket = new RockPacket("You have won with Paper");
                                            LoserPacket = new RockPacket("You have lost with Rock");
                                            m_Clients[index].SetRockChoice("");
                                            c.SetRockChoice("");
                                            m_Clients[index].Send(LoserPacket);
                                            c.Send(WinnerPacket);
                                            break;
                                        }
                                        else if (m_Clients[index].GetRockChoice() == "Rock" && c.GetRockChoice() == "Scissors")
                                        {
                                            WinnerPacket = new RockPacket ("You have won with Rock");
                                            LoserPacket = new RockPacket("You have lost with Scissors");
                                            m_Clients[index].SetRockChoice("");
                                            c.SetRockChoice("");
                                            m_Clients[index].Send(WinnerPacket);
                                            c.Send(LoserPacket);
                                            break;
                                        }
                                        else if (m_Clients[index].GetRockChoice() == "Paper" && c.GetRockChoice() == "Rock")
                                        {
                                            WinnerPacket = new RockPacket("You have won with Paper");
                                            LoserPacket = new RockPacket("You have lost with Rock");
                                            m_Clients[index].SetRockChoice("");
                                            c.SetRockChoice("");
                                            m_Clients[index].Send(WinnerPacket);
                                            c.Send(LoserPacket);
                                            break;
                                        }
                                        else if (m_Clients[index].GetRockChoice() == "Paper" && c.GetRockChoice() == "Scissors")
                                        {
                                            WinnerPacket = new RockPacket("You have won with Scissors");
                                            LoserPacket = new RockPacket("You have lost with Paper");
                                            m_Clients[index].SetRockChoice("");
                                            c.SetRockChoice("");
                                            m_Clients[index].Send(LoserPacket);
                                            c.Send(WinnerPacket);
                                            break;
                                        }
                                        else if (m_Clients[index].GetRockChoice() == "Scissors" && c.GetRockChoice() == "Paper")
                                        {
                                            WinnerPacket = new RockPacket("You have won with Scissors");
                                            LoserPacket = new RockPacket("You have lost with Paper");
                                            m_Clients[index].SetRockChoice("");
                                            c.SetRockChoice("");
                                            m_Clients[index].Send(WinnerPacket);
                                            c.Send(LoserPacket);
                                            break;
                                        }
                                        else if (m_Clients[index].GetRockChoice() == "Scissors" && c.GetRockChoice() == "Rock")
                                        {
                                            WinnerPacket = new RockPacket("You have won with Rock");
                                            LoserPacket = new RockPacket("You have lost with Scissors");
                                            m_Clients[index].SetRockChoice("");
                                            c.SetRockChoice("");
                                            m_Clients[index].Send(LoserPacket);
                                            c.Send(WinnerPacket);
                                            break;
                                        }
                                    }
                                    else if(m_Clients[index].GetRockChoice() != "" && c.GetRockChoice() == "")
                                    {
                                        ChallengeMessage = new RockPacket("You have been challenged to a game of Rock Paper Scissors by " + m_Clients[index].GetNick() + " please reply to their challenge with /"
                                           + m_Clients[index].GetNick() + " followed by /Rock or /Paper or /Scissors");
                                        c.Send(ChallengeMessage);
                                    }
                                    //rockPacket.m_message += (" From " + cName);
                                    //c.Send(rockPacket);
                                }
                            }
                            break;
                        }

                }
                
                //foreach(Client c in m_Clients)
                //{
                //    c.Send(returnedString);
                //}
            }
            m_Clients[index].Close();
            Client tempClient;
            m_Clients.TryRemove(index, out tempClient);
        }

        private string GetReturnMessage(string code)
        {
            return (code);
        }

        private string SearchMessage(string stringToSearch)
        {
            string returnString = "";
            string[] splitString = stringToSearch.Split();
            foreach(string i in splitString)
            {
                if(i.Contains("/"))
                {
                    string newString = i.Remove(0, 1);
                    Console.WriteLine(newString);
                    return newString;
                }
            }
            return (returnString += " Error");
        }

        private string SearchGameMessage(string stringToSearch, Client currentClient)
        {
            string returnString = "";
            string[] splitString = stringToSearch.Split();
            foreach (string i in splitString)
            {
                if (i.Contains("/Rock"))
                {
                    string newString = i.Remove(0, 1);
                    currentClient.SetRockChoice(newString);
                    Console.WriteLine(newString);
                    return newString;
                }
                else if (i.Contains("/Scissors"))
                {
                    string newString = i.Remove(0, 1);
                    currentClient.SetRockChoice(newString);
                    Console.WriteLine(newString);
                    return newString;
                }
                else if (i.Contains("/Paper"))
                {
                    string newString = i.Remove(0, 1);
                    currentClient.SetRockChoice(newString);
                    Console.WriteLine(newString);
                    return newString;
                }
            }
            return (returnString);
        }
    }

    class Client
    {
        private Socket m_Socket;
        private NetworkStream stream;
        /* private StreamReader reader;
        private StreamWriter writer; */
        private BinaryReader reader;
        private BinaryWriter writer;
        private BinaryFormatter formatter;
        private object m_ReadLock;
        private object m_WriteLock;

        private string rockChoice;
        private string nickname;

        public Client(Socket socket)
        {
            m_WriteLock = new object();
            m_ReadLock = new object();
            m_Socket = socket;
            stream = new NetworkStream(socket, true);
            reader = new BinaryReader(stream, Encoding.UTF8);
            writer = new BinaryWriter(stream, Encoding.UTF8);
            formatter = new BinaryFormatter();
            /* reader = new StreamReader(stream, Encoding.UTF8);
            writer = new StreamWriter(stream, Encoding.UTF8); */
        }

        public void Close()
        {
            stream.Close();
            reader.Close();
            writer.Close();

        }

        public Packet Read()
        {
            lock(m_ReadLock)
            {
                int numberOfBytes;
                //return reader.ReadLine();
                if ((numberOfBytes = reader.ReadInt32()) !=-1)
                {
                    byte[] buffer = reader.ReadBytes(numberOfBytes);
                    MemoryStream mStream = new MemoryStream(buffer);
                    return formatter.Deserialize(mStream) as Packet;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Send(Packet message)
        {
            lock(m_WriteLock)
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

        public void SetNick(string message)
        {
            lock (m_WriteLock)
            {
                nickname = message;
            }
        }

        public string GetNick()
        {
            return nickname;
        }

        public void SetRockChoice(string message)
        {
            lock (m_WriteLock)
            {
                rockChoice = message;
            }
        }

        public string GetRockChoice()
        {
            return rockChoice;
        }

    }
}
