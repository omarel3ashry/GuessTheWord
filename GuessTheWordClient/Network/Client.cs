using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;


namespace GuessTheWordClient
{
    internal partial class Client
    {
        public delegate void ClientEventHandler(string msg);
        public delegate void ResponseEventHandler(ResponseMessage response);

        public ushort Id { get => ushort.Parse(IPAddress.ToString().Split('.', 4)[3]); }
        public IPAddress IPAddress { get; set; }
        public Player ThePlayer { get; set; }
        public int Port { get; set; }

        private BackgroundWorker _worker;
        private NetworkStream? _stream;
        private BinaryReader? _reader;

        public ClientEventHandler? OnConnectionChange;
        public ResponseEventHandler? OnLoginResponse;
        public ResponseEventHandler? OnLobbyResponse;
        public ResponseEventHandler? OnRoomResponse;

        public Client(IPAddress iPAddress, int port)
        {

            IPAddress = iPAddress;

            Port = port;
            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += WorkerDoWork;

            Application.ApplicationExit += (s,e) => Disconnect();
        }

        public void Connect() { _worker.RunWorkerAsync(); }

        public void Disconnect()
        {
            _worker.CancelAsync();
            if (_stream != null)
                _stream.Close();
        }

        public void SendRequest(RequestMessage request)
        {
            if (_stream != null)
            {
                _stream.Write(request.Serialize());
                _stream.Flush();
            }

        }

        private void EstablishConnection()
        {
            using TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress, Port);
            _stream = tcpClient.GetStream();
            _reader = new BinaryReader(_stream);
            if (tcpClient.Connected && OnConnectionChange != null)
                OnConnectionChange("Connected!");

            var buffer = new byte[1024];

            while (!_worker.CancellationPending)
            {
                try
                {
                    int received = _reader.Read(buffer);
                    if (received == 0)
                        break;
                    var response = buffer.DeserializeResMsg();
                    Debug.WriteLine(response.MType);
                    if (OnLoginResponse != null)
                        OnLoginResponse(response);
                    if (OnLobbyResponse != null)
                        OnLobbyResponse(response);
                    if (OnRoomResponse != null)
                        OnRoomResponse(response);
                }
                catch (IOException e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }

        private void WorkerDoWork(object? sender, DoWorkEventArgs e)
        {
            EstablishConnection();
        }
    }
}
