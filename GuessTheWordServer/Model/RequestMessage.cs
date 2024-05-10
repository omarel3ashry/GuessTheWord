

namespace GuessTheWordServer
{
    enum MessageType
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

        public RequestMessage(MessageType mType, string playerId, string msg) : this(mType, playerId, msg, 0, '0', 0) { }
        public RequestMessage(MessageType mType, string playerId, ushort roomId) : this(mType, playerId, "", roomId, '0', 0) { }
        public RequestMessage(MessageType mType, string playerId, ushort category, ushort roomId = 0) : this(mType, playerId, "", roomId, '0', category) { }
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
