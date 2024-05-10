using System.Net;
using System.Net.Sockets;



namespace GuessTheWordServer
{
    internal partial class Server
    {
        public delegate void ServerNewClientHandler(string msg);
        public delegate void ServerMessageReceivedHandler(string ip, string msg);
        public delegate void RequestEventHandler(RequestMessage request);


        private List<TcpClient> _clients = new List<TcpClient>();
        private Dictionary<string, Player> _players;
        private Dictionary<ushort, Room> _rooms;
        private ControlRoom _controlRoom;
        private Random _random;

        public event ServerNewClientHandler? OnConnectionChange;
        public event ServerMessageReceivedHandler? OnMessageRecieved;
        public event RequestEventHandler? OnRequest;
        public event RequestEventHandler? OnResponseSent;

        private bool isRunning;

        public Server()
        {
            _players = new Dictionary<string, Player>();
            _rooms = new Dictionary<ushort, Room>();
            _controlRoom = new ControlRoom(_rooms);
            _random = new Random();

        }

        public void FireServer()
        {
            isRunning = true;
            StartServer();
        }

        public void ShutdownServer()
        {
            _clients.Clear();
            isRunning = false;
        }

        private void StartServer()
        {
            using TcpListener _listener = new TcpListener(IPAddress.Loopback, 1414);
            _listener.Start();
            if (OnConnectionChange != null)
                OnConnectionChange($"Listening...");
            while (isRunning)
            {
                TcpClient handler = _listener.AcceptTcpClient();
                _clients.Add(handler);
                if (OnConnectionChange != null)
                    OnConnectionChange($"Client {_clients.Count} connected.");
                new Thread(() => ReceiveClient(handler, _clients.Count - 1)).Start();

            }
            if (OnConnectionChange != null)
                OnConnectionChange("Server Stopped!");
        }

        private void ReceiveClient(TcpClient tcpClient, int i)
        {
            using NetworkStream stream = tcpClient.GetStream();
            var buffer = new byte[1024];
            int received;
            stream.Read(buffer);
            var initialRequest = buffer.DeserializeReqMsg();
            string ip = (tcpClient.Client.RemoteEndPoint as IPEndPoint)!.Address.ToString();
            if (OnMessageRecieved != null)
                OnMessageRecieved(ip, initialRequest.ToJsonString());
            Player player = new Player(initialRequest.PlayerId, tcpClient);
            AddNewPlayer(player, tcpClient);

            while ((received = stream.Read(buffer)) > 0)
            {
                var request = buffer.DeserializeReqMsg();
                if (OnMessageRecieved != null)
                    OnMessageRecieved(ip, request.ToJsonString());

                RequestSwitcher(request);
            }
            if (OnMessageRecieved != null)
                OnMessageRecieved(ip, "Disconnected");
            _clients.Remove(tcpClient);
            RemovePlayer(player);
        }

        private void AddNewPlayer(Player p, TcpClient tcpClient)
        {
            var response = new ResponseMessage(MessageType.LoginResponse, 1, _rooms);
            if (!_players.ContainsKey(p.Id))
            {
                _players.Add(p.Id, p);
                tcpClient.GetStream().Write(response.Serialize());
                tcpClient.GetStream().Flush();
                Console.WriteLine(response.ToJsonString());
            }
            else
            {
                response.Status = 0;
                tcpClient.GetStream().Write(response.Serialize());
                tcpClient.GetStream().Flush();
                Console.WriteLine(response.ToJsonString());
            }

        }
        private void RemovePlayer(Player p)
        {
            if (_players.ContainsKey(p.Id))
            {
                _players.Remove(p.Id);
            }
        }
    }
}
