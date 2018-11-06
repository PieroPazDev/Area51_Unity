using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject target;
    public float ratio = 0.05f;

    // Use this for initialization
    void Start() {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("PlatformChar");
        }
          
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, ratio);
	}
}
