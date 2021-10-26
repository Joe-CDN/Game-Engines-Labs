using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;

    private float move = 0;
    
    private void OnCollisionEnter(Collision collision) {
        //Destroy(gameObject);
        BasicPool.Instance.AddToPool(gameObject);
    }

    void Update()
    {
        move += speed;
        Vector3 position = new Vector3(move, this.transform.position.y, this.transform.position.z);
        
        this.transform.position = position;
    }
}
