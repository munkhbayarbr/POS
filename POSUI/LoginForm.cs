using Microsoft.EntityFrameworkCore;
using PosLibrary.Data;

namespace POSUI
{
    public partial class LoginForm : Form
    {
        private readonly DbContextOptions<Context> _options;

        public LoginForm(DbContextOptions<Context> options)
        {
            InitializeComponent();
            _options = options;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text; 

            using var db = new Context(_options);
            var user = db.Users
                         .AsNoTracking()
                         .SingleOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                
                Hide();
                
                using var main = new MainForm();
                main.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
