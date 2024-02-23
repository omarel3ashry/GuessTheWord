using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;

namespace GuessTheWordServer
{
    enum PlayerState { Idle, One, Two, Spectating }

    internal class Player
    {
        public ushort IpOctet { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public PlayerState State { get; set; }
        public ushort RoomId { get; set; }
        public ushort Score { get; set; }
        public ushort WantToPlayAgain { get; set; }
        [JsonIgnore]
        public TcpClient Client { get; }

        public Player(string playerId, TcpClient tcpClient)
        {
            IPAddress ip = (tcpClient.Client.RemoteEndPoint as IPEndPoint)!.Address;
            IpOctet = ushort.Parse(ip.ToString().Split('.', 4)[3]);
            //Id = string.Concat(name, '#', IpOctet);
            Id = playerId;
            Name = playerId.Split('#')[0];
            State = PlayerState.Idle;
            RoomId = 0;
            Score = 0;
            WantToPlayAgain = 0;
            Client = tcpClient;
        }

        public Player(string id, string name, PlayerState state, ushort roomId,
                      ushort score, ushort wantToPlayAgain)
        {
            Id = id;
            Name = name;
            State = state;
            RoomId = roomId;
            Score = score;
            WantToPlayAgain = wantToPlayAgain;
        }
    }
}
