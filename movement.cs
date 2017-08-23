using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    // Use this for initialization - Happens once per start
    void Start()
    {

    }

    // Update is called once per frame - happens an unlimited amount of times
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y + 0);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.3f, gameObject.transform.position.y + 0);

        }
    }
}