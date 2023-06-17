using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMVP.Model;
using WinFormsMVP.View;
using WinFormsMVP.Presenter;

namespace WinFormsMVP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var repository = new Repository();
            var view = new Form1();
            Presenter.Presenter presenter = new Presenter.Presenter(repository,view);
            Application.Run(view);
        }
    }
}
