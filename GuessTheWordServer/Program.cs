namespace GuessTheWordServer
{
    internal class Program
    {
        enum TestE { aw, ad, dw }
        private static Server server;
        static void Main(string[] args)
        {
            StartServer();
        }

        private static void StartServer()
        {
            if (server == null)
            {
                server = new Server();
                server.OnConnectionChange += Console.WriteLine;
                server.OnMessageRecieved += (no, msg) => Console.WriteLine($"Client {no}: " + msg);
            }
            server.FireServer();
            Console.WriteLine("Listening...");
        }


        private static void Shutdown()
        {
            server.ShutdownServer();
        }
    }
}
