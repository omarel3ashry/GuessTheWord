using System.Runtime.InteropServices;

namespace GuessTheWordClient
{

    internal partial class LoserDialog : Form
    {
        private Client _client;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );
        public LoserDialog(Client client)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80, 80));
            _client = client;
            _client.OnRoomResponse += OnResponseToKick;
        }

        private void OnResponseToKick(ResponseMessage response)
        {
            if (IsHandleCreated && response.MType == MessageType.Kick)
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void OnYesBtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OnNoBtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OnCloseBtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
