using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatable : MonoBehaviour {

    protected bool activated;
    protected List<Activator> linkedActivators = new List<Activator>();

    public void LinkActivator (Activator activator) {
        linkedActivators.Add(activator);
    }

    public Activator[] LinkedActivators() {
        return linkedActivators.ToArray();
    }

    public virtual void Start() {
        if(linkedActivators.Count == 0) {
            OnStart();
        }
	}

	public virtual void OnStart() {
        
    }

    public virtual void OnActive() {
        
    }

    public virtual void OnEnd() {
        
    }
}
//multithreading, procesos especificos dentro de un juego (como juegos online)
//coroutine, procesos asyncronos dentro de Unity

//Ciclo de vida del software 
//testing : unidades, integraciones, validaciones