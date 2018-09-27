using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, ConvertToCampDepth(target.position), Time.deltaTime);
	}

    Vector3 ConvertToCampDepth (Vector3 vector){
        return new Vector3(vector.x, vector.y, Camera.main.transform.position.z);
    }
}
