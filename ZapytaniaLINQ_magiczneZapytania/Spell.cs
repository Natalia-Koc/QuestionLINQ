using System;
using System.Collections.Generic;
using System.Text;

namespace ZapytaniaLINQ_magiczneZapytania
{
    public class Spell
    {
        public String Name { get; set; }
        public Type TypeName { get; set; }
        public int Cost { get; set; }
        public int Cooldown { get; set; }
        public int Effect { get; set; }

        public override string ToString()
        {
            return $"" +
                $"Name: {Name}\n" +
                $"Type: {TypeName}\n" +
                $"Cost: {Cost}\n" +
                $"Cooldown: {Cooldown}\n" +
                $"Effect: {Effect}\n";
        }
        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
}
