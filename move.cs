using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput=Input.GetAxis("Horizontal");

        // moving forward and backward
        body.velocity = new Vector2(horizontalInput*speed,body.velocity.y);
        
    }
}
