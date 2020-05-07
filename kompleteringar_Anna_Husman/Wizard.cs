using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Wizard : Magical
    {
        Spell fireball = new Fireball();
        Spell thunder = new Thunder();

        public Wizard()
        {
            hp = 120;
            sp = 200;


            damage = 10;
            defense = 5;
            agility = 15;

            spellList.Add(fireball);
            spellList.Add(thunder);
        }
    }
}
