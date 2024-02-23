using System.Runtime.InteropServices;


namespace GuessTheWordClient
{
    internal partial class CategoryDialog : Form
    {
        public RequestMessage Request { get; set; }
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

        public CategoryDialog(RequestMessage request)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80, 80));

            Request = request;
        }

        private void OnCloseBtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void OnAnimalBtnClick(object sender, EventArgs e)
        {
            Request.Category = 1;
            DialogResult = DialogResult.OK;
        }

        private void OnSportsBtnClick(object sender, EventArgs e)
        {
            Request.Category = 2;
            DialogResult = DialogResult.OK;
        }

        private void OnFoodBtnClick(object sender, EventArgs e)
        {
            Request.Category = 3;
            DialogResult = DialogResult.OK;
        }
    }
}

