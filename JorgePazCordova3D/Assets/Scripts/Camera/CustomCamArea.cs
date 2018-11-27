using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;

public class CustomCamArea : MonoBehaviour
{

    public TargetData targetData;

    void Start()
    {
        if (!targetData.target)
        {
            targetData.target = transform;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CamBehaviour.main.data = targetData;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CamBehaviour.main.ResetData();

        }
    }


    /*private void OnDrawGizmos()
    {

        if (data.target)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(followPoint, focusPoint);
            Gizmos.DrawSphere(focusPoint, 0.25f);
            Gizmos.color = Color.white;
            Gizmos.DrawWireSphere(followPoint, 0.25f);
        }
    }*/
}