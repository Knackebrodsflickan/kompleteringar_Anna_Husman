using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Thunder : Spell // en av wizards skills som ärver av spell. 
    {
        public Thunder() // metod som heter thunder och innehåller alla klassens egenskaper, så som dess namn som man ser när man kallar på metoden som innehåller listan. 
        {
            element = "electricity";
            damage = 15;
            names = "thunder"; // namnet man ser blir kallat när man kör programmet. 
        }
    }
}
