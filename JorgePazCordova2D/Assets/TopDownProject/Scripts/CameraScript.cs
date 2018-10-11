using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    private Transform player;
    public float topLimit,downLimit;
    public float leftLimit,rigthLimit;

    void Start()
    {
        player = GameObject.Find("Character").transform;
    }

    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(player.position.x, leftLimit, rigthLimit),
                                         Mathf.Clamp(player.position.y, downLimit, topLimit));
                                        
    }
}