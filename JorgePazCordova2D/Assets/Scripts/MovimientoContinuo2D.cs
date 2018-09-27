using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;
using UnityEngine.SceneManagement;

public class MovimientoContinuo2D : MonoBehaviour
{

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Barrel"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Barrel"))
        {
            SceneManager.LoadScene(0);
        }

        if (other.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(2);
        }
    }

    bool FindObstacle (Vector3 direction) {
        RaycastHit2D hit2D = Physics2D.Raycast (transform.position, direction);
        return hit2D && hit2D.collider.CompareTag ("StaticBlock");
    }
}
