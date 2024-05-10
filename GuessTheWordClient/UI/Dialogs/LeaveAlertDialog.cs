using System.Runtime.InteropServices;

namespace GuessTheWordClient
{
    public partial class LeaveAlertDialog : Form
    {
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

        public LeaveAlertDialog()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80, 80));
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

