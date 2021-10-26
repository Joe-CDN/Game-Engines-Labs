using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Hammer : _Weapon
    {
        private int damage;
        private int durability;

        private static int hammerCounter = 0;

        public Hammer(int health, int speed)
        {
            this.damage = health;
            this.durability = speed;

            hammerCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Hammer(damage, durability);
        }

        public override void Talk()
        {
            Debug.Log($"Hello this is Hammer number {hammerCounter}. I deal {damage} damage and have a durability of {durability}");
        }
    }
}
