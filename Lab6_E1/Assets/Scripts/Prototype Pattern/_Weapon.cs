using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
     public abstract class _Weapon
    {
        //This method implements the Prototype design pattern
        public abstract _Weapon Clone();

        public abstract void Talk();
    }
}
