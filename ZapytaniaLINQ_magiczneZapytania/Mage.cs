using System;
using System.Collections.Generic;
using System.Text;

namespace ZapytaniaLINQ_magiczneZapytania
{
    public class Mage
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dextirity { get; set; }
        public int Inteligence { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int MP { get; set; }
        public int MaxMP { get; set; }
        public int Damage { get; set; }
        public int PhysicalResistance { get; set; }
        public int FireResistance { get; set; }
        public int IceResistance { get; set; }
        public int PoisonResistance { get; set; }
        public SpellBook SpellBook { get; set; }

        public override string ToString()
        {
            return $"{Name }, \n" +
                $"Hp {HP}/{MaxHP}, \n" +
                $"MP {MP}/{MaxMP}, \n" +
                $"Lvl {Level}, \n" +
                $"Exp {Experience}, \n" +
                $"Str {Strength}, \n" +
                $"Dex {Dextirity}, \n" +
                $"Int {Inteligence}, \n" +
                $"Dmg {Damage}, \n" +
                $"Res [Physical {PhysicalResistance}, \n" +
                $"FIre {FireResistance}, \n" +
                $"Ice {IceResistance}, \n" +
                $"Poison {PoisonResistance}] \n" +
                $"{SpellBook}";

        }
    }
}
