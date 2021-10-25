using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Sword : _Weapon
    {
        private int damage;
        private int durability;

        private static int swordCounter = 0;

        public Sword(int health, int speed)
        {
            this.damage = health;
            this.durability = speed;

            swordCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Sword(damage, durability);
        }

        public override void Talk()
        {
            Debug.Log($"Hello this is Sword number {swordCounter}. I deal {damage} damage and have a durability of {durability}");
        }
    }
}