using Microsoft.EntityFrameworkCore;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories.RepositoryImp;
namespace POSUI;

public partial class LoginForm : BaseForm
{
    private readonly UserRepository _userRepo;
    private readonly Context _context;
    public LoginForm(Context context)
    {

        InitializeComponent();
        _context = context;
        _userRepo = new UserRepository(context);

    }
    private async void Login(object sender, EventArgs e)
    {
        var username = txtUsername.Text.Trim();
        var password = txtPassword.Text;

        User? user = await _userRepo.ValidateUser(username, password);

        if (user != null)
        {
            MessageBox.Show($"Тавтай морил, {user.Username}!",
                           "Амжилттай нэвтэрлээ",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            Hide();
            using var main = new MainForm(user, _context);
            main.ShowDialog();
            Close();
        }
        else
        {
            MessageBox.Show(
                "Нэвтрэх нэр эсвэл нууц үг буруу байна.",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

  
}
