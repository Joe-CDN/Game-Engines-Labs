using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Axe : _Weapon
    {
        private int damage;
        private int durability;

        private static int axeCounter = 0;

        public Axe(int health, int speed)
        {
            this.damage = health;
            this.durability = speed;

            axeCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Axe(damage, durability);
        }

        public override void Talk()
        {
            Debug.Log($"Hello this is Axe number {axeCounter}. I deal {damage} damage and have a durability of {durability}");
        }
    }
}
