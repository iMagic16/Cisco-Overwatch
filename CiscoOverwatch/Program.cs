using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoOverwatch
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
            Application.Run(new OverwatchMainForm());
        }
    }

    public class Debug
    {
        /// <summary>
        /// Outputs to the console with a timestamp before the message.
        /// Usage: ConOut(Message)
        /// </summary>
        public static void ConOut(string Msg)
        {
            Console.WriteLine("{0}:{1}.{2}|{3}: " + Msg, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
        }

    }
}
