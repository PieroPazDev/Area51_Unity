using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaivour : MonoBehaviour {

    public float speed = 2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Barrel"))
        {
            other.GetComponent<DestroyableObject>().DestroySelf();
            Destroy(gameObject);
        }
    }
}
