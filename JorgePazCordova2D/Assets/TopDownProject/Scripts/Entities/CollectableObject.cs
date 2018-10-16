using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour {

	void Awake() {
        GameControl.instance.objectiveInstances.Add(this);
	}

	public float points;

    public void Collect(){
        Debug.Log("Collect" + points + "Points");
        GameControl.instance.CheckInstantPoint(this);
        Destroy(gameObject);
    }
}
