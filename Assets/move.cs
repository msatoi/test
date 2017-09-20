using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1.0f, 0.0f, 0.0f) * Time.deltaTime;
        }
	}
}
