using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoControlado : MonoBehaviour {

    public float speed = 5;
    public float angSpeed = 50;

    Rigidbody controlRB;

	// Use this for initialization
	void Start () {
        controlRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.Translate (Vector3.forward * Time.deltaTime * speed);
            controlRB.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate (Vector3.back * Time.deltaTime * speed);
            controlRB.velocity = Vector3.back * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //)).Translate (Vector3.left * Time.deltaTime * speed);
            controlRB.velocity = Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate (Vector3.right * Time.deltaTime * speed);
            controlRB.velocity = Vector3.right * speed;
        }
    }

}
