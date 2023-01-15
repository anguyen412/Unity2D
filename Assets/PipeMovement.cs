using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    private float speed = -7f;
    private bool hasPassed;
    private bool gameEnded;

    void Start() {
        hasPassed = false;
        gameEnded = false;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("GameEnded at the start of Update: " + gameEnded);
    
        speed = -7 - Time.time/20;
        rb.velocity = new Vector2(speed, 0);

        Debug.Log("GameEnded after speed change: " + gameEnded);

        if (transform.position.x < -11f && hasPassed == false && gameEnded == false) {
            hasPassed = true;
            if (transform.position.y > 0) {
                Debug.Log("INCREMENTING SCORE, gameHasEnded:" + gameEnded);
                FindObjectOfType<Score>().incrementScore();
            }
        }

        Debug.Log("GameEnded after if statement: " + gameEnded);

    }

    public void StopScore () {
        gameEnded = true;
    }


}
