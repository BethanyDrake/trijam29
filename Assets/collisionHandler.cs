using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionHandler : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D coll){
        Debug.Log("coll");
        var gameObject = coll.gameObject;
        Debug.Log(gameObject);
        (coll.gameObject.GetComponent("Flash2") as Flash2).flash();
        Debug.Log(coll);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
