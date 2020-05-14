using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Spear : Skill // ärver från skill
    {
        public Spear() //metod som heter spear, en metod av klassen och dess egenskaper. Så som vad den heter och vad dess vapen är, och hur mycket damage som den ger. Spear kommer fram när man kallar från main o kallar på listan med skills. 
        {
            Weapon = "stab";
            damage = 8;
            names = "spear";
        }
    }
}
