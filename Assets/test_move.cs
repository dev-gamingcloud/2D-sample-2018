using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_move : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position = new Vector2(transform.position.x, transform.position.y + 2);
        if (Input.GetKey(KeyCode.S))
            transform.position = new Vector2(transform.position.x, transform.position.y - 2);
        if (Input.GetKey(KeyCode.D))
            transform.position = new Vector2(transform.position.x + 2, transform.position.y);
        if (Input.GetKey(KeyCode.A))
            transform.position = new Vector2(transform.position.x - 2, transform.position.y);
    }
}
