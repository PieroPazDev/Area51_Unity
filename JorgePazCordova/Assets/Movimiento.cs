using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public Vector3 position;
    public float speed = 1;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
        position.x += speed * Time.deltaTime;
        transform.position = position;
    }
}
