using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessbg : MonoBehaviour
{
    public float speed;
    public float startPos;
    public float endPos;

    void Update()
    {
        transform.Translate(Vector2.right * -speed * Time.deltaTime); //Moves the BG towards Left (-X)
        

        if(transform.position.x <= startPos) 
        {
            Vector2 bgPos = new Vector2(endPos, 0);
            transform.position =bgPos;
        }
    }
}