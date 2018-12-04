using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Activator : MonoBehaviour {

    public Activatable target;
	
    void Awake () {
        if (target) { target.LinkActivator(this); }
	}

	public virtual bool Use () {
        Debug.Log("Calling Use on Activator");
        return false;
    }

    protected virtual void ActivateStart (Activatable activatable) {
        Debug.Log("Process Started Sent");
    }

    protected virtual void ActivateEnd (Activatable activatable, bool recall = true) {
        Debug.Log("Process Ending Sent");
        activatable.OnEnd();
        if (recall) {
            Activator[] activators = activatable.LinkedActivators();
            foreach (Activator activator in activators) {
                if (activator != this) { activator.ActivateEnd(activatable, false); }
            }
        }
    }
}

//Virtual: Define si se puede sobreescribir o no
//Sino tiene public el hijo no puede acceder
//Protected: Modificador de acceso(solo aplica para el hijo)
