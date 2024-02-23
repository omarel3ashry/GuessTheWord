/*
* @author 3ashry
*/

namespace GuessTheWordClient
{
    internal class ResponseMessage
    {
        public MessageType MType { get; set; }
        public ushort Status;
        public ushort CurrentRoomId { get; set; }
        public string Word { get; set; }
        public Dictionary<ushort, Room>? Rooms { get; set; }

        public ResponseMessage(MessageType type) : this(type, 1, 0, "", null) { }

        public ResponseMessage(MessageType type, ushort status) : this(type, status, 0, "", null) { }

        public ResponseMessage(MessageType type, ushort status, ushort roomId) : this(type, status, roomId, "", null) { }

        public ResponseMessage(MessageType type, ushort status, Dictionary<ushort, Room> rooms) : this(type, status, 0, "", rooms) { }

        public ResponseMessage(MessageType mType, ushort status, ushort currentRoomId,
                              string word, Dictionary<ushort, Room>? rooms)
        {
            MType = mType;
            Status = status;
            CurrentRoomId = currentRoomId;
            Word = word;
            Rooms = rooms;
        }
    }
}
