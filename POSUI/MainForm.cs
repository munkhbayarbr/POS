
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosLibrary.Data;
using PosLibrary.Models;
namespace POSUI;

public partial class MainForm : Form
{
   
        private User _currentUser;

    public MainForm(User user)
    {
        InitializeComponent();
        _currentUser = user;

     
        mnuCategories.Visible = user.Role == "Manager";
        btnEdit.Enabled = btnDelete.Enabled = user.Role == "Manager";


        var products = new Context().Products.ToList();
        dProducts.DataSource = products;
    }

    private void btnAdd_Click(object sender, EventArgs e)

    }

    private void btnEdit_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        
    }
}

