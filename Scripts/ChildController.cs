using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildController : MonoBehaviour
{
    float dirX, moveSpeed = .05f;
    bool moveRight = true;
    public float posX1;
    public float posX2;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > posX1)
            moveRight = false;
        if (transform.position.x < posX2)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed + Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed + Time.deltaTime, transform.position.y);
    }
}