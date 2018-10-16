using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement2D : MonoBehaviour {

    public float speed = 1f;
    public Vector2 direction;
    public Vector3 movement { get { return direction * speed * Time.deltaTime; } }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        transform.Translate (movement);
	}
}
