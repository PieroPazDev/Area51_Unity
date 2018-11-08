using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintPlatform : PlatformBehaviour {

	void Start () {
		
	}

	public override void OnPlatformStep (GameObject reference = null) {
		if (reference == null) { return; }
		reference.GetComponent<PhysicsPlatformMove>().speed.y += targetValue;
	} 
}
