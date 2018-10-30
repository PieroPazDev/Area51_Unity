using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

	// Use this for initialization
    public void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Destruido");
        Destroy(gameObject);
	}

}
