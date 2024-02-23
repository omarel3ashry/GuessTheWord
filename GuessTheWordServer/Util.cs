/*
* @author 3ashry
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GuessTheWordServer
{
    internal static class Util
    {
        public static RequestMessage DeserializeReqMsg(this byte[] bytes)
        {
            MessageType msgType;
            string playerId;
            string msg;
            ushort roomId;
            char selectedChar;
            ushort category;
            using (MemoryStream m = new MemoryStream(bytes))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    msgType = (MessageType)reader.ReadUInt16();
                    playerId = reader.ReadString();
                    msg = reader.ReadString();
                    roomId = reader.ReadUInt16();
                    selectedChar = reader.ReadChar();
                    category = reader.ReadUInt16();
                }
                return new RequestMessage(msgType, playerId,msg, roomId, selectedChar, category);
            }
        }

        public static string ToJsonString(this ResponseMessage msg)
        {
            return JsonConvert.SerializeObject(
                msg, Formatting.Indented,
                [new StringEnumConverter()]);
        }

        public static string ToJsonString(this RequestMessage msg)
        {
            return JsonConvert.SerializeObject(
                msg, Formatting.Indented,
                [new StringEnumConverter()]);
        }

        public static byte[] Serialize(this ResponseMessage msg)
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write((ushort)msg.MType);
                    writer.Write(msg.Status);
                    writer.Write(msg.CurrentRoomId);
                    writer.Write(msg.Word);
                    ushort count = msg.Rooms != null ? (ushort)msg.Rooms.Count : (ushort)0;
                    writer.Write(count);
                    if (msg.Rooms != null)
                        foreach (var pair in msg.Rooms!)
                        {
                            writer.Write(pair.Key);
                            byte[] roomBytes = pair.Value.Serialize();
                            writer.Write((ushort)roomBytes.Length);
                            writer.Write(roomBytes);
                        }
                }
                return m.ToArray();
            }
        }

        public static byte[] Serialize(this Player p)
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(p.Id);
                    writer.Write(p.Name);
                    writer.Write((ushort)p.State);
                    writer.Write(p.RoomId);
                    writer.Write(p.Score);
                    writer.Write(p.WantToPlayAgain);
                }
                return m.ToArray();
            }
        }

        public static byte[] Serialize(this Game g)
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(g.WordToView.ToString()!);
                    writer.Write(string.Join("", g.Result));
                    writer.Write(g.ChoosedChars);
                }
                return m.ToArray();
            }
        }

        public static byte[] Serialize(this Room r)
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(r.RoomId);

                    byte[] playerOneBytes = r.PlayerOne.Serialize();
                    writer.Write((ushort)playerOneBytes.Length);
                    writer.Write(playerOneBytes);

                    if (r.PlayerTwo != null)
                    {
                        byte[] playerTwoBytes = r.PlayerTwo.Serialize();
                        writer.Write((ushort)playerTwoBytes.Length);
                        writer.Write(playerTwoBytes);
                    }
                    else writer.Write((ushort)0);

                    writer.Write(string.Join(",", r.Spectators.Select(sp => sp.Id).ToArray()));
                    writer.Write((ushort)r.State);
                    byte[] gameBytes = r.TheGame.Serialize();
                    writer.Write((ushort)gameBytes.Length);
                    writer.Write(gameBytes);
                }
                return m.ToArray();
            }
        }
    }
}
