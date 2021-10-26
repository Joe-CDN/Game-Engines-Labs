using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace Prototype.MonsterSpawner
//{
//    public class Spawner
//    {
//        private _Monster prototype;
//        
//        public Spawner(_Monster prototype)
//        {
//            this.prototype = prototype;
//        }
//        
//        public _Monster SpawnMonster()
//        {
//            return prototype.Clone();
//        }
//    }
//}

namespace Prototype.WeaponSpawner
{
    public class Spawner
    {
        private _Weapon prototype;
        
        public Spawner(_Weapon prototype)
        {
            this.prototype = prototype;
        }
        
        public _Weapon SpawnWeapon()
        {
            return prototype.Clone();
        }
    }
}

