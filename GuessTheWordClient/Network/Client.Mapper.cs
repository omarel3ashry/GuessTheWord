

namespace GuessTheWordClient
{
    internal partial class Client
    {
        public void RequestSendMsg(string msg)
        {
            var request = new RequestMessage(MessageType.MsgRequest, ThePlayer.Id, msg, 0, '\0', 0);
            SendRequest(request);
        }

        public void RequestCreateRoom(ushort category)
        {
            var request = new RequestMessage(MessageType.CreateRoomRequest, ThePlayer.Id, "", 0, '\0', category);
            SendRequest(request);
        }

        public void RequestJoinRoom(ushort roomId)
        {
            var request = new RequestMessage(MessageType.JoinRoomRequest, ThePlayer.Id, "", roomId, '\0', 0);
            SendRequest(request);
        }

        public void RequestWatchRoom(ushort roomId)
        {
            var request = new RequestMessage(MessageType.WatchRoomRequest, ThePlayer.Id, "", roomId, '\0', 0);
            SendRequest(request);
        }

        public void RequestStartGame()
        {
            var request = new RequestMessage(MessageType.StartGameRequest, ThePlayer.Id);
            SendRequest(request);
        }

        public void RequestSelectChar(char c)
        {
            var request = new RequestMessage(MessageType.SelectCharRequest, ThePlayer.Id, "", 0, c, 0);
            SendRequest(request);
        }

        public void RequestLeaveRoom()
        {
            var request = new RequestMessage(MessageType.LeaveRoomRequest, ThePlayer.Id);
            SendRequest(request);
        }
    }
}
