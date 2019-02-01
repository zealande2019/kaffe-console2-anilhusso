using System;
using System.Collections.Generic;
using System.Text;

namespace KaffeConsoleAppNetCore
{
    class Flatwhite : kaffe, Imælk
    {
        public virtual string Styrke()
        {
            return "stærk";
        }
        public override int Pris()
        {
            return 40;
        }
        public int MlMælk()
        {
            return 120;
        }
    }
}
