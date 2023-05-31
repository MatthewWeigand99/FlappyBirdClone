using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int flyStrength;
    public LogicScript logic;
    public bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic")
                          .GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && alive)
        {
            Debug.Log("Jumped");
            rb.velocity = Vector2.up * flyStrength;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other) 
    {
        logic.gameOver();
        alive = false;
    }
}
