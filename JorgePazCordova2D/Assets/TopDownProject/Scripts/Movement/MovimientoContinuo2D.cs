using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;
using UnityEngine.SceneManagement;

public class MovimientoContinuo2D : MonoBehaviour {
    public float speed;
    public List<AxisPair> axes;

    //public GameObject bulletPrefab;

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
            if (Input.GetKey(axes[i].keyCode) && !FindObstacle(axes[i].direction))
            {
                movement += axes[i].direction;
            }
        }
        //--------------------------------
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
          //  Instantiate(bulletPrefab, transform.position + Vector3.up, transform.rotation);
        //}
        //--------------------------------
        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Barrel"))
        {
            GameControl.instance.RestartLevel();
        }
        else if (other.CompareTag("CamArea"))
        {
            Camera.main.GetComponent<CamControl>().SwitchTarget(other.transform, 7);
        }
        else if (other.CompareTag("Collectable"))
        {
            other.GetComponent<CollectableObject>().Collect();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("CamArea"))
        {
            Camera.main.GetComponent<CamControl>().SwitchTarget(null);
        }
    }

    bool FindObstacle(Vector3 direction)
    {
        RaycastHit2D[] hits2D = Physics2D.RaycastAll(transform.position, direction, 0.5f);
        Debug.DrawRay(transform.position, direction / 2, Color.green);

        foreach (RaycastHit2D hit2D in hits2D)
        {
            if (hit2D.collider.CompareTag("StaticBlock"))
            {
                return true;
            }
        }

        return false;
    }
}
