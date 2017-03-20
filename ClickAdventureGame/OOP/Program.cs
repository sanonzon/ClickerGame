using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logic.Quest quests = new Logic.Quest();
            quests.InitQuests();

            Logic.Quest.adventureQuests();

            
            Application.EnableVisualStyles();
            try
            {
                //Application.SetCompatibleTextRenderingDefault(false);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
            Application.Run(new ClickAdventureBase());
        }
    }
}
