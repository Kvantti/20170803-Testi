﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class lookat : MonoBehaviour {


	public Transform target;

	// Update is called once per frame
	void Update () {
	
		transform.LookAt (target);

	}
}
