using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTAR
{

    internal class Output
    {
        /*
        //Output system
        static void Output(NPCs player, NPCs opponent, int top_screen, int event_id, int dialog_id)
        {
            Console.Clear();

            output_top_screen(top_screen);

            //outputs the bottom half of the screen, depending where in the game you are

            switch (event_id)
            {
                case 0: output_title(player, dialog_id); break;
                case 1: output_combat(player, opponent, dialog_id); break;
                default: break;
            }
        }

        //outputs the top half, mostly grafics
        static void output_top_screen(int id)
        {
            switch (id)
            {
                case 0: output_title_top_screen(); break;
                default: break;
            }
        }
        //outputs the top half of the title screen 
        static void output_title_top_screen()
        {
            Console.WriteLine("░░░░█░░░░░░░░░█░░░░░██████░░░░░░░░░█░░░░░░░░░░█████░░░░");
            Console.WriteLine("░░░░█░░░░░░░░█░░░░░░░░░░░█████░░░░█░█░░░░░░░░█░░░░░█░░░");
            Console.WriteLine("░░░░█░░░█░░░█░░░█░░░░░░░█░░░░░░░░█░░█░░░░░░░█░░░░░░█░░░");
            Console.WriteLine("░░░░█░░██░░█░░░░░░░░░░░█░░░░░░░░█░░░█░░░░░░█░███████░░░");
            Console.WriteLine("░░░░█░█░█░█░░░░█░░░░░░█░░░░░░░░██████░░░░░█░░█░░░░░░░░░");
            Console.WriteLine("░░░░██░░██░░░░█░░░░░░█░░░░░░░░█░░░░░█░░░░█░░░░█░░░░░░░░");
            Console.WriteLine("░░░░█░░░█░░░░█░░░░░░█░░░░░░░░█░░░░░░█░░░█░░░░░░█░░░░░░░");
            Console.WriteLine("      Wilhelms     text     adventure     roguelight   ");
        }
        static void output_title(NPCs player, int id)
        {
            switch (id)
            {
                case 0: output_title_case_0(); break;
            }
        }
        static void output_title_case_0()
        {
            Console.WriteLine("");
            Console.WriteLine("             Click any button to continue              ");
        }
        static void output_combat(NPCs player, NPCs opponent, int id)
        {
            switch (id)
            {
                case 0: output_combat_case_0(player, opponent); break;
                default: break;
            }
        }
        static void output_combat_case_0(NPCs player, NPCs opponent)
        {
            Console.WriteLine("A Wild " + "Level " + opponent.GETlevel() + " " + opponent.GETname() + " appears!");
            Console.WriteLine("What will " + player.GETname() + " do?");
        }
        */
    }
}
