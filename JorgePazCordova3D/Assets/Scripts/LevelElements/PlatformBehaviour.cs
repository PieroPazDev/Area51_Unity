using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : Activatable {

    Vector3 startPoint;
    Vector3 currentTarget;
    public Vector3 targetPoint;

    public float speed;

    public Vector3 currentMomentum { get { return (currentTarget - transform.position).normalized * speed; }}

    Color defaultColor;
    Renderer rend;
    float intensityDropValue = 0.3f;

    // Use this for initialization
    void Start () {
        startPoint = transform.position;
        currentTarget = targetPoint;
        SetRenderValues();
	}

    void SetRenderValues() {
        if (!rend && (rend = GetComponent<Renderer>())) {
            defaultColor = rend.material.color;
        }
        rend.material.color = activated ? defaultColor : (Color)Color32.Lerp(defaultColor, Color.black, intensityDropValue);
    }

    void Update() {
        if (activated){
            OnActive();
        }    
    }

    public override void OnStart() {
        activated = true;
        SetRenderValues();
    }

    // Update is called once per frame
    public override void OnActive () {
        if(transform.position == currentTarget){
            currentTarget = (currentTarget == targetPoint) ? startPoint : targetPoint;
        }

        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
	}

    public override void OnEnd() {
        if (activated) {
            activated = false;
            SetRenderValues();
        }
    }

        void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(startPoint, Vector3.one * 0.25f);
        Gizmos.DrawCube(targetPoint, Vector3.one * 0.25f);
	}
}
