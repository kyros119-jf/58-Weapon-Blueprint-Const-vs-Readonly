using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace _58_Weapon_Blueprint_Const_vs_Readonly
{
    public class Weapon
    {
       public const int MAX_WEAPON_LEVEL = 10;
       public readonly Guid WeaponId;
        public readonly DateTime CreatedDate;


        public string Name { get; set; }
        public int Damage { get; set; }



        public Weapon(string name, int damage)
        {
            WeaponId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            Name = name;
            Damage = damage;

            if (damage < 0)
            {
                Console.WriteLine("Damage cannot be negative.");

                Damage = 0;

            }

            else
            {
                Damage = damage;

            }
        }

    }
}
