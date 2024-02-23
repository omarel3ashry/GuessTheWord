namespace GuessTheWordClient
{
    internal class MainControl
    {

        public static void replaceControl(Control container, Control control)
        {
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            container.Controls.Add(control);
        }
    }
}
