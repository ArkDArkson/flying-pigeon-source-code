using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class pipeScript : MonoBehaviour
{
public BoxCollider2D collision;
    public logicScript logic;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move() {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
