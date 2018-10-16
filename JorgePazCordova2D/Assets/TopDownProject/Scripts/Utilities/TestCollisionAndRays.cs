using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollisionAndRays : MonoBehaviour{

    float distance = 20f;
    Vector3 source, target;

    void Start (){
        target = Vector3.forward * distance;
    }

	void Update(){
        source = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit2D = Physics2D.Raycast(source, target);

        if (hit2D){
            Debug.Log(hit2D.collider.name);
        }
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 50), "This is a label");
    }

    private void OnDrawGizmos()
    {
    Gizmos.color = Color.red;
    Gizmos.DrawLine(source, target);
    }
}
