using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using JetBrains.Annotations;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject pipes;
    public int spawnRate;
    public float Timer;
    
    public float lowestPoint;

    public float highestPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < spawnRate) {
Timer = Timer + Time.deltaTime;
        }
        else {
            spawnPipe();
            Timer = 0;
        }
    }

    void spawnPipe() {
        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}
