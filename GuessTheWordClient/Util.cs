/*
* @author 3ashry
*/

namespace GuessTheWordClient
{
    internal static class Util
    {

        public static byte[] Serialize(this RequestMessage msg)
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write((ushort)msg.MType);
                    writer.Write(msg.PlayerId);
                    writer.Write(msg.Message);
                    writer.Write(msg.RoomId);
                    writer.Write(msg.SelectedChar);
                    writer.Write(msg.Category);
                }
                return m.ToArray();
            }
        }

        public static ResponseMessage DeserializeResMsg(this byte[] bytes)
        {
            MessageType msgType;
            ushort status;
            ushort currentRoomId;
            string word;
            Dictionary<ushort, Room> rooms;
            using (MemoryStream m = new MemoryStream(bytes))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    msgType = (MessageType)reader.ReadUInt16();
                    status = reader.ReadUInt16();
                    currentRoomId = reader.ReadUInt16();
                    word = reader.ReadString();
                    ushort roomsCount = reader.ReadUInt16();
                    rooms = new Dictionary<ushort, Room>(roomsCount);
                    for (int i = 0; i < roomsCount; i++)
                    {
                        ushort key = reader.ReadUInt16();
                        ushort bufferSize = reader.ReadUInt16();
                        //byte[] roomBuffer = new byte[bufferSize];
                        byte[] roomBuffer = reader.ReadBytes(bufferSize);

                        //reader.Read(roomBuffer, (int)m.Position, bufferSize);
                        Room value = roomBuffer.DeserializeRoom();
                        rooms.Add(key, value);
                    }
                }
                return new ResponseMessage(msgType, status, currentRoomId, word, rooms);
            }
        }

        public static Player DeserializePlayer(this byte[] bytes)
        {
            string id, name;
            PlayerState state;
            ushort roomId, score, wantToPlayAgain;
            using (MemoryStream m = new MemoryStream(bytes))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    id = reader.ReadString();
                    name = reader.ReadString();
                    state = (PlayerState)reader.ReadUInt16();
                    roomId = reader.ReadUInt16();
                    score = reader.ReadUInt16();
                    wantToPlayAgain = reader.ReadUInt16();
                }
                return new Player(id, name, state, roomId, score, wantToPlayAgain);
            }
        }

        public static Game DeserializeGame(this byte[] bytes)
        {
            char[] showingChars;
            ushort[] gameResult;
            string choosedChars;
            using (MemoryStream m = new MemoryStream(bytes))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    showingChars = reader.ReadString().ToCharArray();
                    gameResult = reader.ReadString().ToCharArray().Select(c => Convert.ToUInt16(c)).ToArray();
                    choosedChars = reader.ReadString();
                }
                return new Game(showingChars, choosedChars, gameResult);
            }
        }

        public static Room DeserializeRoom(this byte[] bytes)
        {
            ushort roomId;
            Player p1;
            Player? p2;
            List<string> spectators;
            RoomState state;
            Game theGame;
            using (MemoryStream m = new MemoryStream(bytes))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    roomId = reader.ReadUInt16();

                    ushort p1BufferSize = reader.ReadUInt16();
                    byte[] p1Buffer = reader.ReadBytes(p1BufferSize);
                    p1 = p1Buffer.DeserializePlayer();

                    ushort p2BufferSize = reader.ReadUInt16();
                    if (p2BufferSize > 0)
                    {
                        byte[] p2Buffer = reader.ReadBytes(p2BufferSize);
                        p2 = p2Buffer.DeserializePlayer();
                    }
                    else p2 = null;

                    string[] spec = reader.ReadString().Split(',',StringSplitOptions.RemoveEmptyEntries);
                    spectators = new List<string>(spec);
                    state = (RoomState)reader.ReadUInt16();
                    ushort bufferSize = reader.ReadUInt16();
                    byte[] gameBuffer = reader.ReadBytes(bufferSize);
                    theGame = gameBuffer.DeserializeGame();
                }
                return new Room(roomId, p1, p2, spectators, state, theGame);
            }
        }

        // RoomForm Utility
        public static void CreateBoardBtnList(UserControl form, List<CurvedButton> buttonList, EventHandler eventHandler)
        {
            int x = 300, y = 370;
            char[][] chars =
            [
                ['Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P'],
                ['A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L'],
                ['Z', 'X', 'C', 'V', 'B', 'N', 'M'],
            ];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                int noOfBtns = i == 0 ? 10 : i == 1 ? 9 : 7;
                int xMargin = i == 0 ? 0 : i == 1 ? 40 : 120;

                for (int j = 0; j < noOfBtns; j++)
                {
                    //buttons.Add(CreateBtn((char)(65 + count), x + (80 * j) + xMargin, y + (80 * i)));
                    buttonList.Add(CreateBoardBtn(chars[i][j], x + (80 * j) + xMargin, y + (80 * i), eventHandler));
                    count++;
                }
            }
            form.Controls.AddRange(buttonList.ToArray());
        }

        private static CurvedButton CreateBoardBtn(char ch, int x, int y, EventHandler eventHandler)
        {
            CurvedButton btn = new CurvedButton();

            btn.BackColor = Color.FromArgb(203, 177, 136);
            btn.BackgroundColor = Color.FromArgb(203, 177, 136);
            btn.BorderColor = Color.PaleVioletRed;
            btn.BorderRadius = 25;
            btn.BorderSize = 0;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.Location = new Point(x, y);
            btn.Size = new Size(76, 69);
            btn.Name = string.Concat("char", ch, "Btn");
            btn.Text = ch.ToString();
            btn.TabIndex = 1;
            btn.TextColor = Color.Black;
            btn.UseVisualStyleBackColor = false;
            btn.Click += eventHandler;
            return btn;

        }

        public static void CreateWordBtnList(UserControl form, List<CurvedButton> buttonList, char[] chars)
        {
            int x = 300, y = 220;
            int count = chars.Length;
            int centerX = x + ((800 - (count * 80)) / 2);
            for (int i = 0; i < count; i++)
            {
                buttonList.Add(CreateWordBtn(chars[i], centerX + (80 * i), y));
            }
            form.Controls.AddRange(buttonList.ToArray());
        }

        private static CurvedButton CreateWordBtn(char ch, int x, int y)
        {
            CurvedButton btn = new CurvedButton();

            btn.BackColor = Color.White;
            btn.BackgroundColor = Color.White;
            btn.BorderColor = Color.White;
            btn.BorderRadius = 25;
            btn.BorderSize = 3;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatStyle = FlatStyle.Standard;
            btn.ForeColor = Color.Black;
            btn.Location = new Point(x, y);
            btn.Size = new Size(76, 69);
            btn.Name = string.Concat("word", ch, "Btn");
            btn.Text = ch.ToString();
            btn.TabIndex = 1;
            btn.TextColor = Color.Black;
            btn.UseVisualStyleBackColor = false;
            return btn;
        }
    }
}
