using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        //Destroy(gameObject);
        BasicPool.Instance.AddToPool(gameObject);
    }

    private void Awake(){
        EatSomeRamLikeARealGameObject();
    }

    int[] data;

    private void EatSomeRamLikeARealGameObject(){
        data = new int[1000];
        for(int i=0; i<1000; i++){
            data[i] = i;
        }
    }
}
