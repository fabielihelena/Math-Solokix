using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {

    public string actualMaterial;
    public string actualPoligon;


	void Start ()
    { this.actualMaterial = ""; this.actualPoligon = ""; }

	void FixedUpdate ()
    {
        Debug.Log(this.actualPoligon);
	}
}
