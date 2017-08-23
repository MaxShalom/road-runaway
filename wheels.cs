using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheels : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow)){
            gameObject.transform.Rotate(new Vector3(10, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(-10, 0, 0));
        }
    }
}
