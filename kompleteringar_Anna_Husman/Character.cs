using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Character // masterclassm ärver inte från någon. Men innehåller däremot strings som name och lite hp och spell points o sånt.
    {
        public string name;
        public int hp; // som sagt, lite logik
        public int sp;

        public void TakeDamage(int damageTaken) // en metod som i princip körs igång och visar hur mycket damage som en av karaktärerna tagit, 
        {
            hp = hp - damageTaken;
        }
    }
}
