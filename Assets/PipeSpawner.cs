using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    Vector2 location;
    public GameObject Pipe1;
    public GameObject Pipe2;
    public GameObject Pipe3;
    public GameObject Pipe4;
    public GameObject Pipe5;
    private float timeToSpawn = 1f;
    public float timeBetweenWaves = 1f;
    private int lastRandom = 1;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn) {
            SpawnPipes();
            timeToSpawn = Time.time + timeBetweenWaves;
            timeBetweenWaves -= 0.01f;
        }
    }

    void SpawnPipes() {
        int random = Random.Range(1, 6);
        if (random == lastRandom) {
            random += 2;
            if (random > 5) {
                random-=5;
            }
        }
        lastRandom = random;
        

        if (random == 1)
        {
            location = new Vector2(14f, 4.5f);
            Instantiate(Pipe1, location, Quaternion.identity);
            location = new Vector2(14f, -2.5f);
            Instantiate(Pipe5, location, Quaternion.identity);
        } else if (random == 2) {
            location = new Vector2(14f, 4f);
            Instantiate(Pipe2, location, Quaternion.identity);
            location = new Vector2(14f, -3f);
            Instantiate(Pipe4, location, Quaternion.identity);
        } else if (random == 3) {
            location = new Vector2(14f, 3.5f);
            Instantiate(Pipe3, location, Quaternion.identity);
            location = new Vector2(14f, -3.5f);
            Instantiate(Pipe3, location, Quaternion.identity);
        } else if (random == 4) {
            location = new Vector2(14f, 3f);
            Instantiate(Pipe4, location, Quaternion.identity);
            location = new Vector2(14f, -4f);
            Instantiate(Pipe2, location, Quaternion.identity);
        } else if (random == 5) {
            location = new Vector2(14f, 2.5f);
            Instantiate(Pipe5, location, Quaternion.identity);
            location = new Vector2(14f, -4.5f);
            Instantiate(Pipe1, location, Quaternion.identity);
        }

    }
}
