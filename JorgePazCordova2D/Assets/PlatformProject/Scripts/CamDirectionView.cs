﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDirectionView : MonoBehaviour {

    public Transform targetEntity;
    MouseTargetBehaivour mouseScript;
    public float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
        mouseScript = targetEntity.GetComponent<MouseTargetBehaivour>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        //Vector3 targetPos = new Vector3(targetEntity.position.x, targetEntity.position.y, targetEntity.position.z);

        Vector3 point = targetEntity.position + (mouseScript.mouseDirectionNormalized * 3f);

        Vector3 targetPos = new Vector3(point.x, targetEntity.position.y, transform.position.z);
        MoveToTarget(targetPos);
	}

    void MoveToTarget (Vector3 target) {
        transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed +1/mouseScript.distanceDelta * Time.deltaTime);
    }

    public void Test (){
        
    }
}
