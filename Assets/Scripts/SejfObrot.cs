﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SejfObrot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Rotate (0, 0, 1);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0, 0, -1);
		}
	}
}
