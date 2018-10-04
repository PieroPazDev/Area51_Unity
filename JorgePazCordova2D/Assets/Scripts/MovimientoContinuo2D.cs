using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;
using UnityEngine.SceneManagement;

public class MovimientoContinuo2D : MonoBehaviour {

    public float speed;

    public List<AxisPair> axes;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

        for (int i = 0; i < axes.Count; i++)
        {
            if (Input.GetKey(axes[i].keyCode))
            {
                movement += axes[i].direction;
            }
        }
        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       //if (other.CompareTag("Enemy")) {
         //   Debug.Log("Meta");
        //}

        if (other.CompareTag("Barrel")) {
            GameControl.instance.RestartLevel();
            //SceneManager.LoadScene(0);
        } else if (other.CompareTag("CamArea")){
            Camera.main.GetComponent<CamControl>().SwitchTarget (other.transform, 18); 
        }

    }



    bool FindObstacle (Vector3 direction) {
        RaycastHit2D[] hits2D = Physics2D.RaycastAll (transform.position, direction, 0.5f);
        Debug.DrawRay(transform.position, direction, Color.green, 2);

        foreach(RaycastHit2D hit2D in hits2D){
            if (hit2D.collider.CompareTag("StaticBlock")){
                return true;
            }
        }
        return false;

    }
}
