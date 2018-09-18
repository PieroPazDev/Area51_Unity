using System.Collections.Generic;
using UnityEngine;

public class MovimientoControlado2D : MonoBehaviour
{

    public float speed;
    public float limitRight, limitLeft;

    [System.Serializable]
    public struct AxisPair {
        public KeyCode keyCode;
        public Vector3 direction;
    }

    public List<AxisPair> axes;

    // Use this for initialization
    void Start(){
        
    }

    void Update(){
        for (int i = 0; i < axes.Count; i++){
            if(Input.GetKeyDown(axes[i].keyCode)){
                transform.Translate(axes[i].direction);
            }
        }
    }

    void CheckStep (Vector3 targetDir) {
        Vector3 CheckPosition = transform.position + targetDir;
    }
}