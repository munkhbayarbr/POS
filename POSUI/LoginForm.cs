using Microsoft.EntityFrameworkCore;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories;
namespace POSUI;

public partial class LoginForm : Form
{
    private readonly UserRepository _userRepo;
    public LoginForm()
    {
        InitializeComponent();
        _userRepo = new UserRepository();

    }
    private void Login(object sender, EventArgs e)
    {
        var username = txtUsername.Text.Trim();
        var password = txtPassword.Text; 

        User? user = _userRepo.ValidateUser(username, password);

        if (user != null)
        {
            MessageBox.Show($"Тавтай морил, {user.Username}!",
                           "Амжилттай нэвтэрлээ",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            Hide();
            using var main = new MainForm(user);
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
