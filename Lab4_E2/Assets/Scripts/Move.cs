using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    //private float speed = PersistanceManager.instance.moveSpeed;
    private float dirX, dirZ;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * PersistanceManager.instance.moveSpeed;
        dirZ = Input.GetAxis("Vertical") * PersistanceManager.instance.moveSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
