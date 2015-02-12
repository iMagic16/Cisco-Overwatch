using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoOverwatch
{
    static class Overwatch
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.Title = "Cisco Overwatch by James Walsh";
            Application.Run(new OverwatchMainForm());
        }
    }

    public class Debug
    {
        /// <summary>
        /// Outputs to the console with a timestamp before the message.
        /// Usage: ConOut(Message, Err?, SSH?, Switch name if SSH, IP of switch)
        /// </summary>
        public static void ConOut(string Msg, bool ERR = false, bool SSH = false, string Switch = "", string IP = "")
        {
            if (SSH)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}:{1}.{2}|{3}: SSH: {4}:({5})" + Msg, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, Switch, IP);
            }
            else if (ERR)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}:{1}.{2}|{3}: ERROR: " + Msg, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}:{1}.{2}|{3}: " + Msg, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            }
        }
        public static void Restart()
        {
            Debug.ConOut("API UNAVAIL", true);
        }
    }
}
