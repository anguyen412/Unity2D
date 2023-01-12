using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    private float speed = -7f;

    // Update is called once per frame
    void Update()
    {
        speed = -7 - Time.time/20;
        rb.velocity = new Vector2(speed, 0);

    }
}
