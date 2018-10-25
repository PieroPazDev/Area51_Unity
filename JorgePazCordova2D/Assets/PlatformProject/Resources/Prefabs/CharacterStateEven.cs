using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateEven : MonoBehaviour {

	public Color currentColor;
	public Gradient colorSet;
	
	public float targetTime;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		currentColor = colorSet.Evaluate(targetTime);

	}
}
