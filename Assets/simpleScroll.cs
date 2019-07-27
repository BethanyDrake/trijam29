using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleScroll : MonoBehaviour
{

    public float speed = 1;
    public float maxLeft;
    public float maxRight;
    // Start is called before the first frame update
    void Start()
    {

    }

     void Update()
    {
        if (transform.position.x < maxLeft) {
            transform.position = new Vector3(maxRight, transform.position.y, 0);
        }


        transform.Translate(Vector3.left * Time.deltaTime * speed);


    }
}
