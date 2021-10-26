using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class SpawnController : MonoBehaviour
    {
        private Sword swordPrototype;
        private Axe axePrototype;
        private Hammer hammerPrototype;

        private Spawner[] weaponSpawners;


        void Start()
        {
            swordPrototype = new Sword(30, 10);
            axePrototype = new Axe(25, 15);
            hammerPrototype = new Hammer(20, 20);

            weaponSpawners = new Spawner[] {
                new Spawner(swordPrototype),
                new Spawner(axePrototype),
                new Spawner(hammerPrototype)
            };

        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                Spawner swordSpawner = new Spawner(swordPrototype);
                Spawner axeSpawner = new Spawner(axePrototype);
                Spawner hammerSpawner = new Spawner(hammerPrototype);

                Sword newSword = swordSpawner.SpawnWeapon() as Sword;
                Axe newAxe = axeSpawner.SpawnWeapon() as Axe;
                Hammer newHammer = hammerSpawner.SpawnWeapon() as Hammer;

                newSword.Talk();
                newAxe.Talk();
                newHammer.Talk();
            }
        }
    }
}
