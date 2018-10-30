using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongCorto : MonoBehaviour {

    public float speed;
    public float lenght;
    private float counter;
    private float startPosition;

    private float actualPosition;
    private float lastPosition;

    public bool horizontal;

	// Use this for initialization
	void Start () {
        if (horizontal) startPosition = transform.position.x;
        else startPosition = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime * speed;

        if (horizontal){
            transform.position = new Vector2(Mathf.PingPong(counter, lenght) + startPosition, transform.position.y);
            actualPosition = transform.position.x;
            if (actualPosition < lastPosition) transform.localScale = new Vector3(-1, 1, 1);
            if (actualPosition > lastPosition) transform.localScale = new Vector3(1, 1, 1);
            lastPosition = transform.position.x;
        }
        else
        {
            transform.position = new Vector2(transform.position.x, Mathf.PingPong(counter, lenght) + startPosition);
        }
    }

    public void RestartLevel()
    {
        Debug.Log("Collect");

        Destroy(gameObject);
    }
}
