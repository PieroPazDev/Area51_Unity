using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMovement2D : EntityMovement2D {

    public float distance = 1;
    private float currentDistance;

    public float totalMovement { get { return currentDistance + movement.magnitude; } }

	// Use this for initialization
	void Start () {
		
	}

	protected override void Update(){

        currentDistance += movement.magnitude;
        //Logica PingPong
        if(currentDistance >= distance){
            float delta = totalMovement - distance;
            transform.Translate(direction.normalized * delta);
            direction *= -1;
            currentDistance = 0;
        }
        else {
            base.Update();
        }
	}
}
