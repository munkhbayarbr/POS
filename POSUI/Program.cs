using Microsoft.EntityFrameworkCore;
using PosLibrary.Data;
using System;

namespace POSUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlite($"Data Source={Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}/pos.db");

            // Ensure DB + seed applied
            using (var db = new Context(optionsBuilder.Options))
                db.Database.Migrate();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(optionsBuilder.Options));

        }
    }
}