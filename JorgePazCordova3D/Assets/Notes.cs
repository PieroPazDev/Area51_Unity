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

//Comportamiento(Behaviour):
//Accion(es)
//Contexto (Cuando? Por que?)
//Naturaleza

//Inteligencia Artificial:
//Algoritmo (Estado: mantiene el rango de posibilidades para dicho cambio de comportamiento) (Estado: Indicador de comportamiento)
//Decisiones (Decision adecuada para la sutuaciòn)
//Ambiente (Factores considerados bueno o malo, situacional, de contexto interno o externo)
//Comportamientos
//Depende del estado varia el comportamiento: tambièn -->
//Estados comprenden:  comportamiento y parametros de identidad que hacen funcional el comportamiento
//Condiciones de la entidad
//(Estado: ideas de los comportamientos)

//Machine Learning
//Polimorfismo

//Genètica - Rango de mutaciòn (Aleatorio)
//Inteligencia Artificial - Investigar: Redes Neuronales
//FSM Finite State Machine (Maquina de Estados Finita) cantidad limitada para cada una de las entidades

//  MAQUINA DE ESTADOS

//      EVENT
//                 1              2
//                   0             1   
// S  0 Patroll-- A.Found Enemy.Lost Enemy
// T               follow      . patroll     
// A                           .  
// T                           .
// E  1 Folow -- B.  follow    . patroll
//

// combinacion de estado con evento me da la decision a tomar
// enum ---  internamente son enteros
// int en byte : 4bytes
// un array puede tener las dimensiones que se le agregue