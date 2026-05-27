using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTAR
{
    class Imput
    {

        public ConsoleKeyInfo ReadKey()
        {
            // Read a key without displaying it
            return Console.ReadKey(intercept: true);

        }
        public int ReadValue()
        {
            
                int eingabe = 0;
                bool check;

                    check = int.TryParse(Console.ReadLine(), out eingabe);

                return eingabe;
            
        }
    }
}
