using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash2 : MonoBehaviour
{


    private Color oldColor;
    private bool flashing = false;
    private SpriteRenderer sr;

    public float flashTime = 0.2f;
    private float timeRemaining;

    public void flash() {
        Debug.Log("flashing");
        oldColor = sr.color;
        sr.color = Color.red;
        timeRemaining = flashTime;
        flashing = true;
    }
    // Start is called before the first frame update
    void Start() {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flashing) {
            Debug.Log(Time.deltaTime);
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
        }

        if (flashing && timeRemaining < 0) {
            flashing = false;
            GetComponent<SpriteRenderer>().color = oldColor;;
        }

    }
}
