//global scope
using System;
using System.Windows.Forms;

//namespace scope
namespace Itse1430.MovieLib.Host
{
    //type scope
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //local scope
        static void Main ()
        {
            System.Windows.Forms.Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new MainForm ());
        }
    }
}
