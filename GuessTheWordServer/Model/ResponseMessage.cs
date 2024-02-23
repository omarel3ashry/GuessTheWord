/*
* @author 3ashry
*/

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

namespace GuessTheWordServer
{
    internal class ResponseMessage
    {
        public MessageType MType { get; set; }
        public ushort Status;
        public ushort CurrentRoomId { get; set; }
        public string Word { get; set; }
        public Dictionary<ushort, Room>? Rooms { get; set; }

        public ResponseMessage(MessageType type, ushort status, string word) : this(type, status, 0, word, null) { }

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
