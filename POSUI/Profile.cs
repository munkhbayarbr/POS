using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosLibrary;
using PosLibrary.Models;
namespace POSUI;

public partial class Profile : Form
{
    private readonly User _currentUser;
    public Profile(User user)
    {
        InitializeComponent();
        _currentUser = user;
        LoadProfile();
    }
    private void LoadProfile()
    {
        lblName.Text = lblName.Text + _currentUser.Username;
        lblRole.Text = lblRole.Text + _currentUser.Role;
    }
    private void back(object sender, EventArgs e)
    {
        Close();
    }
    private void LogOut(object sender, EventArgs e)
    {
        Hide();
        MessageBox.Show(
              "Амжилттай.",
              "Logged out.",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
          );
        using var login = new LoginForm();
        login.ShowDialog();
        Application.Exit();
    }

 
}
