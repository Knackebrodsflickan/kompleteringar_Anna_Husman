using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Magical : Klass
    {
        public List<Spell> spellList = new List<Spell>();

        public void ShowSpellList()
        {
            for (int i = 0; i < spellList.Count; i++)
            {
                Console.WriteLine(spellList[i].names);
            }



            Console.ReadKey();
        }

    }
}
