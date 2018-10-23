using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTargetBehaivour : MonoBehaviour {

    public Vector2 localMousePos { get { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }}
    public Vector3 mouseDirectionNormalized { get { return (localMousePos - (Vector2)transform.position).normalized; }}
    public float distanceDelta {get{return (localMousePos - (Vector2)transform.position).magnitude;}}

    public Transform targetObjetc;

    // Use this for initialization
	void Start () {
        targetObjetc.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {

        targetObjetc.position = localMousePos;

        Debug.DrawLine(transform.position, localMousePos, Color.cyan);
	}

}
