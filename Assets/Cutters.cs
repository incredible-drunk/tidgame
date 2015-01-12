﻿using UnityEngine;
using System.Collections;

public class Cutters : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Blades collision!");
		if(other.gameObject != null){
			if(other.rigidbody2D != null){
				Debug.Log("Falling at: " + other.rigidbody2D.velocity.y);
				if(other.rigidbody2D.mass >= 3 && other.rigidbody2D.velocity.y < -3){
					this.gameObject.GetComponentInChildren<CutterBlades>().CutJoint();
				}
				
			}
		}
		
	}
}