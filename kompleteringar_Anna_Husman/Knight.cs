using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Knight : Physical
    {
        Knight()
        {
            hp = 200;
            sp = 50;

            damage = 20;
            defense = 15;
            agility = 5;

            skillList.Add("Slash");
            skillList.Add("Punt");
            skillList.Add("Slap");

        }
    }
}
