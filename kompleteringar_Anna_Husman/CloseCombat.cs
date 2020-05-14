using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class CloseCombat : Skill // ärver från skill
    {
        public CloseCombat() // metod som heter closecombat, en metod av klassen och dess egenskaper. Så som vad den heter och vad dess vapen är, och hur mycket damage som den ger. 
        {
            Weapon = "punch";
            damage = 5;
            names = "Close combat";
        }
    }
}
