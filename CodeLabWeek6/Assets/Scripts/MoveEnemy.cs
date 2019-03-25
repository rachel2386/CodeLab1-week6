using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float velocity;
    
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        velocity = -velocity;
    }
}
