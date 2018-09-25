using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMovement2D : EntityMovement2D {

    public float distance = 1;
    private float currentDistance;

	// Use this for initialization
	void Start () {
		
	}

	protected override void Update(){

        currentDistance += movement.magnitude;
        if(currentDistance >= distance){
            direction *= -1;
            currentDistance = 0;
        }
        //Logica PingPong

        base.Update();
	}
}
