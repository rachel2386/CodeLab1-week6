using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D myRB;
    public float speed; 
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRB.velocity = (Vector2.right * Input.GetAxis("Horizontal") + Vector2.up * Input.GetAxis("Vertical")) * speed;
    }
}
