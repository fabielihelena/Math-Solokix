using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {

    public string actualMaterial;
    public string actualPoligon;
    public int actualQuantity;
    public GameObject actualPuzzle;

	void Start ()
    { this.actualMaterial = ""; this.actualPoligon = ""; }

	void FixedUpdate ()
    {
        Debug.Log(this.actualPoligon);
	}
}
