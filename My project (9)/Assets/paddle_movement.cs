using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_movement : MonoBehaviour
{


    Rigidbody2D rb;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed , 0f);
    }
}
