

namespace GuessTheWordClient
{
    public enum MessageType
    {
        LoginRequest,
        LoginResponse,
        MsgRequest,
        MsgResponse,
        CreateRoomRequest,
        CreateRoomResponse,
        JoinRoomRequest,
        JoinRoomResponse,
        WatchRoomRequest,
        WatchRoomResponse,
        NewWatcherNotification,
        StartGameRequest,
        StartGameResponse,
        SelectCharRequest,
        SelectCharResponse,
        GameWin,
        GameLose,
        LeaveRoomRequest,
        LeaveRoomResponse,
        AcceptPlayAgainRequest,
        AcceptPlayAgainResponse,
        RefusePlayAgainRequest,
        RefusePlayAgainResponse,
        Kick,
        Update
    }

    internal class RequestMessage
    {
        public MessageType MType { get; set; }
        public string PlayerId { get; set; }
        public string Message { get; set; }
        public ushort RoomId { get; set; }
        public char SelectedChar { get; set; }
        public ushort Category { get; set; }

        public RequestMessage(MessageType mType, string playerId) : this(mType, playerId, "", 0, '0', 0) { }
        public RequestMessage(MessageType mType, string playerId, string msg, ushort roomId, char selectedChar, ushort category)
        {
            MType = mType;
            PlayerId = playerId;
            Message = msg;
            RoomId = roomId;
            SelectedChar = selectedChar;
            Category = category;
        }
    }
}
