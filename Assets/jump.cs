using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    private float velocity = 0;
    public float gravity = 1;

    public float jumpSpeed = 5;
    public float groundHeight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump")) {
            this.velocity = jumpSpeed;
            transform.Translate(Vector3.up * Time.deltaTime * velocity);
        }

        if (transform.position.y < groundHeight) {
            transform.position = new Vector3(transform.position.x, groundHeight, 0);
            velocity = 0;
        }
        else {
            velocity -= gravity;
             transform.Translate(Vector3.up * Time.deltaTime * velocity);

        }





    }
}
