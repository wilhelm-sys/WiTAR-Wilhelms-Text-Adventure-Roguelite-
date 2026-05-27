using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTAR
{
    class State
    {
        Imput _imputkeyboard = new();
        public ConsoleKeyInfo RequestImput(int state)
        {
            switch (state) {
                case 0: return _imputkeyboard.
                default: return _imputkeyboard.ReadKey();

            }
        }
    }
}
