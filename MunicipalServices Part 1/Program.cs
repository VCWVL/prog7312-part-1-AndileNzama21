using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices_Part_1
{
    // File: Program.cs
    using System;
    using System.Windows.Forms;

    namespace MunicipalServicesApplication
    {
        internal static class Program
        {
            /// <summary>
            /// The main entry point for the application
            /// </summary>
            [STAThread]
            static void Main()
            {
                // Standard Windows Forms application initialization
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
