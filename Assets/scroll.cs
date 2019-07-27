using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -21) {
            transform.position = new Vector3(21, -3.5f, 0);
        }


        transform.Translate(Vector3.left * Time.deltaTime * speed);


    }
}
