using QLTT.Common;
using QLTT.Controls;
using QLTT.Controls.Admin;
using QLTT.Controls.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserForm());
        }
    }
}
