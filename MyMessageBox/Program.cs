using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMessageBox
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
            MyMessageBox mb = new MyMessageBox("Заголовок окна", "Пора бы сделать выбор, пока не стало слишком поздно...", 10); 
            Application.Run(mb);
        }
    }
}
