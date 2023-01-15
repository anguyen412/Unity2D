using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{   

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) {
            rb.velocity = new Vector2(rb.velocity.x, 7);
        }
    }
}
