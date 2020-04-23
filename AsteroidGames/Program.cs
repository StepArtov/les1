using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Form game_form = new Form();
            //Screen.PrimaryScreen.WorkingArea.Height
            game_form.Width = 800;
            game_form.Height = 600;

            game_form.Show();

            Game.Initialize(game_form);
            Game.Load();
            Game.Draw();

            Application.Run(game_form);

            //System.Threading.Thread.Sleep(10000);
            //Application.Run();
        }
    }
}