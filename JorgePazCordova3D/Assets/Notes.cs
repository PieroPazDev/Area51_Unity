using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

// [System.Serializable] el objeto puede ser pasado a serie binaria y devuelto intacto
// hilo principal(main thread)
// todo lenguaje que va para un sistema operativo tiene main
// sistema y procesamiento de datos
// system.threading
// generar un hilo que lo referencie y lo pueda usar despuès
// tener en cuenta la maquina para el procesamiento
// threading proceso asincrono - ejecuta dependiendo de controladores separados
// la data debe venir del main thread
// threading genera procesos y cuando pides un thread tengas la posibilidad de guardarlo
// los procesos no se sabe cuando llegan o se van
// unity tiene procesos asincronos, pero no usa threading
// no todo proceso asincrono no es threading - pero todo threading tiene un proceso asincrono
// hacer coroutienes pensando que tengan yield return
// yield (pausar algo)
// yield break - saco proceso y lo tiro
// yield return - lo mando, lo guardo y listo
// threading consulta con el sistema operativo y se pueden crear otros threads
// unity trabaja con un solo thread para trabajar con los procesos
// WindowWizard - WindowEditor

//overload
//delegate
//mcdn.... declaraciòn de un delegate
// save unsaved
// eventos