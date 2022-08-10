using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    Rigidbody2D rb;
    float hor;
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hor * speed, 0);
    }
}
