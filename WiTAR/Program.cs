using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace WiTAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleInitialization();
            NPCs player = ActorsInit(0);
            NPCs opponent = ActorsInit(1);
            State currentState = new();
            //Loading Save File
            //Output(player, opponent, 1, 1, 0);
            do
            {
                currentState.RequestKey();
                //Imput();
                //Logic();
                //Output();

            } while (true);
        }

        static void ConsoleInitialization()
        {
            Console.CursorVisible = false;
            Console.Title = "WiTAR";
        }
        static NPCs ActorsInit(int id) {
            switch (id)
            {
                case 0:
                    Player player = new Player();
                    player.Player_init();
                    return player;
                case 1:
                    Goblin goblin = new Goblin();
                    goblin.CreatureInit();
                    return goblin;
                default:
                    Dummy dummy = new Dummy();
                    dummy.CreatureInit();
                    return dummy;
            }

        }




        
    }
}
