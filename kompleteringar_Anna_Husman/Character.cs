using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Character
    {
        public string name;
        public int hp;
        public int sp;

        public void TakeDamage(int damageTaken)
        {
            hp = hp - damageTaken;
        }
    }
}
