using System.Drawing.Drawing2D;
namespace GuessTheWordClient
{
    public class RoundedPicBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);

            base.OnPaint(pe);
        }
    }

}