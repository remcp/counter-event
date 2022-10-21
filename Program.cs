using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Pause_teller;
using teller_met_timerevent;

namespace Pause_teller
{
    class Exe
    {
        public static void Main()
        {
            Aanuit aanuit = new Aanuit();
            int teller = 0;
            bool tel = true;
            System.Timers.Timer seconden = new System.Timers.Timer(1000);
            seconden.Start();
            seconden.Elapsed += (sender, e) => teller = Tel_event(sender, e, teller);
            tel = aanuit.Switch(tel);
            while (true)
            {
                tel = aanuit.Switch(tel);
                if (tel == true)
                {
                    seconden.Start();
                }
                else
                {
                    seconden.Stop();
                }
            }
        }


        public static int Tel_event(Object source, System.Timers.ElapsedEventArgs e, int teller)
        {
            teller++;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(teller);
            return teller;
        }
    }
}