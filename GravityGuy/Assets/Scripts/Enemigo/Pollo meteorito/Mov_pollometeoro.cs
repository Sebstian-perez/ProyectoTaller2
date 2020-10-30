using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_pollometeoro : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Vector2 direccion;
    // Start is called before the first frame update
    

    

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direccion * moveSpeed * Time.fixedDeltaTime);
    }
}
