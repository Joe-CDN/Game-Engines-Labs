using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    public Text health;
    
    void Start ()   
     {
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = PersistanceManager.instance.sound;

         health.text = PersistanceManager.instance.healthVal.ToString();
     }  

    void OnCollisionEnter(Collision collision)
    {
        //this method is better because you can just add a tag to any object and call it enemy to be able to destroy it
        if (collision.collider.tag.Equals("Enemy") && collision.impulse.y > 0.6f)
        {
            GetComponent<AudioSource> ().Play ();
            PersistanceManager.instance.healthVal -= 10;
            health.text = PersistanceManager.instance.healthVal.ToString();
            Destroy(collision.gameObject);
        }
    }   
}
