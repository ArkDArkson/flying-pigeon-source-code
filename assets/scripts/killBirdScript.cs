using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBirdScript : MonoBehaviour
{
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
logic.killBird();
    }
}
