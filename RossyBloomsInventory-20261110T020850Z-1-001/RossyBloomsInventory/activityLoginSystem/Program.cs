using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activityLoginSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNewInstance;
            using (var singleInstanceMutex = new System.Threading.Mutex(true, "activityLoginSystem.SingleInstance", out createdNewInstance))
            {
                if (!createdNewInstance)
                    return;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SignInForm());
            }
        }
    }
}
