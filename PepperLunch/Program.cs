using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PepperLunch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// '
        /// 
        public static frmLogin frmlogin { get; set; }
        public static frmContainer frmcontainer  { get;set; }
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmlogin = new frmLogin();
            Application.Run(frmlogin);
        }
    }
}
