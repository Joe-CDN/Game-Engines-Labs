using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public AudioClip sound;
    public Text health;

    private int healthValue = 100;

    void Start ()   
     {
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = sound;

         health.text = "100";
     }  

    void OnCollisionEnter(Collision collision)
    {
        //this method is better because you can just add a tag to any object and call it enemy to be able to destroy it
        if (collision.collider.tag.Equals("Enemy") && collision.impulse.y > 0.6f)
        {
            GetComponent<AudioSource> ().Play ();
            healthValue -= 10;
            health.text = healthValue.ToString();
            Destroy(collision.gameObject);
        }
    }   
}
