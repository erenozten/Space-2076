using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceGame;

namespace SpaceGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //checking if files are ignored
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpaceForm());
        }
    }
}
