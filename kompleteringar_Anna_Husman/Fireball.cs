using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleteringar_Anna_Husman
{
    class Fireball : Spell
    {
        public Fireball() // metod som heter fireball, ärver från spell som är mästerklassen. namnger vilken spell det är, så när vi kallar den från listan så kommer det som
            //står uder names komma upp. I det här fallet? fire. och visar annan statestik som vilket element och hur mkt damage.
        {
            element = "fire";
            damage = 10;
            names = "fireball";
        }
    }
}
