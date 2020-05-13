using System;
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
            Wizard wizard1 = new Wizard();
            Knight knight1 = new Knight();

            Console.WriteLine("Please choose a Class!");
            Console.WriteLine("Write ´1´ for Magical || Write `2` for Physical");
            String ChooseClass = Console.ReadLine();
            if(ChooseClass != "1" && ChooseClass != "2")
            {
                Console.WriteLine("Seems like something went wrong! please try again :) ");
                Console.ReadKey();
            }
            if(ChooseClass == "1")
            {
                Console.WriteLine("You have choosen Magical! Congratulations player, you are a Wizard! If you want to see your spells write spell. ");
                string ShowSpellList = Console.ReadLine();
                if(ShowSpellList == "spell")
                {
                    

                    for (int i = 0; i < wizard1.spellList.Count; i++)
                    {
                        Console.WriteLine(wizard1.spellList[i].element);
                    }



                    Console.ReadKey();
                }
            }
            else if(ChooseClass == "2")
            {
                Console.WriteLine("You have choosen Physical! Congratulations, You are now a knight, and tis but a scratch! Write skill to view your Skill set.");
                string ShowSkilllist = Console.ReadLine();
                if(ShowSkilllist == "skill")
                {
                    for (int i = 0; i < knight1.skillList.Count; i++)
                    {
                        Console.WriteLine(knight1.skillList[i].Weapon);

                        Console.ReadKey();

                    }
                }
            }
            
        }
    }
}
