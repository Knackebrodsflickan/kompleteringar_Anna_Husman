using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Wizard : Magical // ärver av magical, samma business som knight.
    {

        public string returnName(string Methodname) // metod som i princip retunerar namnet som en spelare skriver in. ännu mer logik i klasserna!!! 
        {
            return name = Methodname;
        }

        Spell fireball = new Fireball(); //its his skiiiiills boiiii, alltså två klasser vi skapat tidigare som är hans spells, som vi nu gör som karaktärer isch så vi akan använde dem.
         Spell thunder = new Thunder();

        public void Choosenclass() //en metod som tilllåter oss att printa ut skillist
        {

        }

        public Wizard() // en metod för wizard som innehåller hens hp, sp etc. olika egenskaper. Innehåller också hens spells och så
        {
            hp = 120;
            sp = 200;


            damage = 10;
            defense = 5;
            agility = 15;

            spellList.Add(fireball);
            spellList.Add(thunder);
            //kan ex, lägga till yttligare en skill som heter punch, men då måste jag först skapa en klass. så här är om an vill lägga till i listan .

        }
    }
}
