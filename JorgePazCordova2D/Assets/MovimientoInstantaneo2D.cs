using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

public class MovimientoInstantaneo2D : MonoBehaviour
{


    public float speed;
    public float limitRight, limitLeft;


    public List<AxisPair> axes;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        for (int i = 0; i < axes.Count; i++)
        {
            if (Input.GetKeyDown(axes[i].keyCode) && !FindObstacle(axes[i].direction))
            {
                transform.Translate(axes[i].direction);
            }
        }
    }

    bool FindObstacle(Vector3 direction)
    {
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position + direction, Vector3.forward);

        if (hit2D && hit2D.collider.CompareTag("MovableBlock"))
        {
            hit2D.collider.transform.Translate(direction);
        }

        return hit2D ? hit2D.collider.CompareTag("StaticBlock") : false;
    }
}
