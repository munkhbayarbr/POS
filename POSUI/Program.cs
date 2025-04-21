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

           
            using (var db = new Context())
            {
               
                db.Database.Migrate();
            }
                
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
