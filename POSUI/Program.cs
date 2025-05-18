using Microsoft.EntityFrameworkCore;
using PosLibrary.Data;
using System;
using System.Windows.Forms;

namespace POSUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var context = new Context();
            context.Database.Migrate();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(context));
        }

    }
}
