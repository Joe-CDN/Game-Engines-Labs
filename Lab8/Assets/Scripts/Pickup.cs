using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public Text pickedUp;

    public static int score;

    public static event System.Action<string> pickUpFifty;
    public static event System.Action<string> pickUpHundred;

    void Update()
    {
        pickedUp.text = "Picked Up: " + score;

        if(score == 50)
        {
            pickUpFifty?.Invoke("Picked up 50!");
        }
        if(score == 100)
        {
            pickUpHundred?.Invoke("Picked up 100!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("bomb")){
            score++;
            Destroy(collision.gameObject);
        }
    }
}
