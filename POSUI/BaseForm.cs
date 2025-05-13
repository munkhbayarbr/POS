public class BaseForm : Form
{
    private bool isFullscreen = true;

    public BaseForm()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.WindowState = FormWindowState.Maximized;
        this.KeyPreview = true;
        this.KeyDown += keyDown;
    }

    private void keyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F11)
        {
            fullScreen();
        }
    }

    private void fullScreen()
    {
        if (isFullscreen)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            isFullscreen = false;
        }
        else
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            isFullscreen = true;
        }
    }
}
