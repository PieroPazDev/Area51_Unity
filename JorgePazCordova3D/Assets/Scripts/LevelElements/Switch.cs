using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Activator {

    public bool isSwitched;
    public Color activeColor;
    public Color inactiveColor;

    public Activatable target;

	void Start() {
        GetComponent<Renderer>().material.color = inactiveColor;
	}

    public override bool Use () {
        if (!isSwitched) { ActivateStart(target); } else { ActivateEnd(target); }
        return isSwitched;
    }

	public override void ActivateStart(Activatable activatable) {
        isSwitched = true;
        GetComponent<Renderer>().material.color = activeColor;
    }

    public override void ActivateEnd(Activatable activatable) {
        isSwitched = false;
        GetComponent<Renderer>().material.color = inactiveColor;
    }
}
