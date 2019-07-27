using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1;
    public float maxLeft;
    public float maxRight;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < maxLeft) {
            transform.position = new Vector3(maxRight, transform.position.y, 0);
        }


        transform.Translate(Vector3.left * Time.deltaTime * speed);


    }
}
