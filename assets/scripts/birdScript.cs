using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public int jumpPower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKey(KeyCode.Space)) {
                jump();
        }
    }
    void jump() {
        rigidBody.velocity = Vector2.up * jumpPower;
    }
}
