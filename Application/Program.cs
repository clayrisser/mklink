using System;
using System.Windows.Forms;

namespace mkLink {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            string fileName = "";
            if (args.Length > 0) {
                fileName = args[0];
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(fileName));
        }
    }
}
