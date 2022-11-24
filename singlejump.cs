using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private bool isground;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hi=Input.GetAxis("Horizontal");
        //movement forward/backward
        rb.velocity= new Vector2(hi*speed,rb.velocity.y);
        //jumping
        if(Input.GetKey(KeyCode.Space)){
            if(isground)
                rb.velocity= new Vector2(rb.velocity.x,speed);
            isground=false;
        }
    }
    //collides ground or not
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("ground"))
            isground=true;
    }
}
