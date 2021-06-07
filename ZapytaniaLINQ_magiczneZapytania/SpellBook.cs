using System;
using System.Collections.Generic;
using System.Text;

namespace ZapytaniaLINQ_magiczneZapytania
{
    public class SpellBook : List<Spell>
    {
        public override string ToString()
        {
            String str = "";
            foreach (var item in this)
            {
                str += item.ToString();
            }
            return str;
        }
    }
}
