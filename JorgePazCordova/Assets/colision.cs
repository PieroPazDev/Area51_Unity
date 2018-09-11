using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void OnTriggerEnter (Collider other) {
        Destroy(other.gameObject);
	}
}
