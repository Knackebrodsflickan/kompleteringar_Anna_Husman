using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Magical : Klass // samma grej som physical, ärver av klass. 
    {
        public List<Spell> spellList = new List<Spell>(); // en lista som innehåller klasserna thunder och fireball, som är två spells som wizard använder sig utav

        public void ShowSpellList() // en metod för att kalla på listan, och visa den i main
        {
            for (int i = 0; i < spellList.Count; i++) // for loop som räknar ihop listan
            {
                Console.WriteLine(spellList[i].names); //tar listan och skriver ut vad som står i listan, i de här fallet namnen på the wizards skills. alltså fireball och thunder. 
            }



            Console.ReadKey();
        }

    }
}
