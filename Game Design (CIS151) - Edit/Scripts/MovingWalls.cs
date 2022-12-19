using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour
{
    public float moveSpeed = 3f;
    private bool pingOrPong;

    void Update()
    {
        if (transform.position.y <= -7)
            pingOrPong = true;
        else if (transform.position.y >= 7)
            pingOrPong = false;

        if (pingOrPong == true)
            transform.position += transform.up * (Time.deltaTime * moveSpeed);
        else
            transform.position -= transform.up * (Time.deltaTime * moveSpeed);
    } // I read about Mathf.PingPong but it sounded like more work... 
}
