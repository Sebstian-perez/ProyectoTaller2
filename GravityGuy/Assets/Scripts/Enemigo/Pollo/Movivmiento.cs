using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movivmiento : MonoBehaviour
{
    
    
    public float speed;

    
        
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                GetComponent<Rigidbody2D>().velocity = speed * Vector2.left;
            }

            
        }
        
}
