using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Physical : Klass // ärver från Klass
    {
        public List<Skill> skillList = new List<Skill>(); // en lista som innehåller alla knights skills, som senare anropas från program. 

        public void ShowSkilllist() // en metod som är gjord för att anropa det skilllist innehåller, alltså close combat och spear
        {
            for (int i = 0; i < skillList.Count; i++) // här är de mesta av min logik ahhaha, en for loop som ( tack vare count ) räknar ihopp och de som är i listan
            {
                Console.WriteLine(skillList[i].names); // tack vare stringen "names" i close combat och spear, så när man kallar skilllist så skriver den ut spear och closecombat, alltså knights två skils. 
              

            }

            Console.ReadKey();
        }
    }
}
