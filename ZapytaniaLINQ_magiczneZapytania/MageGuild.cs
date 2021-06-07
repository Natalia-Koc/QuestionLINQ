using System;
using System.Collections.Generic;
using System.Text;

namespace ZapytaniaLINQ_magiczneZapytania
{
    public class MageGuild
    {
        public List<Mage> Mages { get; set; } = new List<Mage>();
        public void AddMage(Mage mage)
        {
            Mages.Add(mage);
        }
        public override string ToString()
        {
            String str = "";
            foreach (var item in Mages)
            {
                str += item.ToString();
            }
            return str;
        }
    }
}
