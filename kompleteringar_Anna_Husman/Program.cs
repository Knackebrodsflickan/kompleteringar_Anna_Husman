using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Location = new Queue(); // i managed to sneak IN A QUEUE its och vadå det passar inte in här? jätte behövligt :) 
            Location.Enqueue("Forest"); // basically, har gjort en ny queue nu som heter location. Och dem man gör här är att man har queéd em. 
            Location.Enqueue("Mountain"); // så wow har en mountain a forest and a deseret
            Location.Enqueue("Desert");

            foreach(Object obj in Location) // vi gör en grej som heter object eller obj som i princip håller alla locations
            {// genom att använda en foreach så går vi igenom alla alla element av the queue
                Console.WriteLine(obj); // så det är denna som faktiskt skriver ut alla location platser- 
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("These are the places where you can choose to fight in! There are currently : " + Location.Count + " of them!");
            Console.WriteLine("Please choose one."); // genom att använda oss av "COUNT" så räknar vi hur många locations det är, och displayar dem. 
            string ChooseLocation;
            ChooseLocation = Console.ReadLine();
            Console.WriteLine("You have choosen: " + ChooseLocation); // vilken location spelaren skrivit in. 

            Console.ReadKey();


            Wizard wizard1 = new Wizard(); // skapar en ny wizard, en ny "karaktär"
            Knight knight1 = new Knight();

            Console.WriteLine("Please choose a Class!");
            Console.WriteLine("Write ´1´ for Magical || Write `2` for Physical");
            String ChooseClass = Console.ReadLine(); // en string som låter spelaren skriva ex då "1" om dem vill välja 1 eller skriva "2" - dem får egentligen skriva va dem vill men de där är de enda programmet kommer reagera på- 
            if(ChooseClass != "1" && ChooseClass != "2") // kontroll check, där om du skriver något annat än 1 eller 2 så blir får du ett meddelande som ber dig försöka igen
            {
                Console.WriteLine("Seems like something went wrong! please try again :) "); 
                Console.ReadKey();
            }
            if(ChooseClass == "1") // om spelaren skriver 1 så kommer detta hända, i princip
            {
                Console.WriteLine("You have choosen Magical! Congratulations player, you are a Wizard! If you want to see your spells write spell. ");
                string ShowSpellList = Console.ReadLine();
                if(ShowSpellList == "spell") // om spelaren skrev in spell, så kommer du köra en metod som räknar upp en list som heter spelllist. för wizard är det spells, och för knight är det skills. 
                {

                    wizard1.ShowSpellList(); // här så har vi då karaktär 1 som vi skapade där uppe, som körs i en metod i magical. 
                                             // det denna gör är att den räknar upp listan, som innehåller alla namnen på wizardens spells. 
                    string answer;
                    Console.WriteLine("What would you like to name your character?"); // MEEER LOGIIIIIK KOLLLA HIIIIIT
                    answer = Console.ReadLine(); // låter spelarens skriva in ett namn till yer wizard. 
                    wizard1.returnName(answer); // kör en metod som ska retunera namnet

                    Console.WriteLine("Name of your wizard: ");
                    Console.WriteLine(wizard1.name); // och här kallar vi på nmetoden som ger namnet jippie!! 

                    Console.ReadKey();

                }
            }
            else if(ChooseClass == "2") // samma princip här, playern valde 2; alltså physical
            {
                Console.WriteLine("You have choosen Physical! Congratulations, You are now a knight, and tis but a scratch! Write skill to view your Skill set.");
                string ShowSkilllist = Console.ReadLine();
                if(ShowSkilllist == "skill") // om spelaren skrev in skill så kommer metoden showskilllist dra igång. Detta innebär att detta händer:
                {
                    knight1.ShowSkilllist(); // knight 1, yttligare en karaktär, körs en metod som heter showskilllist som visar vad knight har för typ av skills, kör den från en lista. 

                    string answers;
                    Console.WriteLine("would you like to name your character?"); // MER LOGIK MICKE
                    answers = Console.ReadLine(); // läser in vad spelaren skriver

                    knight1.returnName(answers); // metod som retunerar namnet ( alltså answers, vad spelaren skrev )
                    Console.WriteLine("name of your knight: ");
                    Console.WriteLine(knight1.name); // skriver ut vad namnet på karaktären. 

                    Console.ReadKey();
                }
            }
            
        }
    }
}
