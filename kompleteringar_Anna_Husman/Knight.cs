using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Knight : Physical // ärver då av klassen physical
    {

        public string returnName(string Methodname) // metod som i princip retunerar namnet som en spelare skriver in. ännu mer logik i klasserna!!! 
        {
            return name = Methodname;
        }


        Skill spear = new Spear(); // its his skiiiiills boiiii, alltså två klasser vi skapat tidigare som är hans skills, som vi nu gör som karaktärer isch så vi akan använde dem. 
        Skill closeCombat = new CloseCombat();

        public void ChooseClass() // en metod som tilllåter oss att printa ut knights skill list. 
        {

        }

        public Knight() // en metod för knight som innehåller hens hp, sp etc. olika egenskaper. Innehåller också hens skills och så
        {
            hp = 200;
            sp = 50;

            damage = 20;
            defense = 15;
            agility = 5;

            skillList.Add(spear);
            skillList.Add(closeCombat);
            //kan ex, lägga till yttligare en skill som heter punch, men då måste jag först skapa en klass. 
            

        }
    }
}
