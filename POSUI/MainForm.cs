
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosLibrary.Models;
namespace POSUI;

public partial class MainForm : Form
{
    private readonly User _currentUser;
    public MainForm(User user)
    {
        InitializeComponent();
        _currentUser = user;
        btn.Text = _currentUser.Username;
    }
}
