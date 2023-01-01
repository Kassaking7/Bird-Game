using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float flapStrength = 10;
    public LogicScript logic;
    public bool birdIsAlive = true;
    private bool rotateUp = true;
    private bool rotateDown = false;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsAlive && Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
        if (myRigidbody.velocity.y > 0)
        {
            if (rotateUp)
            {
                transform.Rotate(0, 0, 20, Space.World);
                rotateUp = false;
                rotateDown = true;
            }

        }
        else
        {
            if (rotateDown)
            {
                transform.Rotate(0, 0, -20, Space.World);
                rotateUp = true;
                rotateDown = false;
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
