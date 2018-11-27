using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    public virtual void ActivateStart(Activatable activatable){
        Debug.Log("Process Started Sent");
    }

    public virtual void ActivateEnd(Activatable activatable)
    {
        Debug.Log("Process Started Sent");
    }
}

//Virtual: Define si se puede sobreescribir o no
//Sino tiene public el hijo no puede acceder
//Protected: Modificador de acceso(solo aplica para el hijo)
