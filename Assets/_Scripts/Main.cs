using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {

    public string actualMaterial;
    public string actualPoligon;
    public int actualQuantity;
    public GameObject actualPuzzle;
    public GameObject[] shapes;
    public Texture[] textures;
    public float actualHigh;
    public float actualSize;
    
    public void SpawnObject(Vector3 startPosition)
    {
        if(actualPoligon.Equals("Cube"))
        {
            GameObject obj = shapes[0];
            obj.SetActive(true);
            obj.tag = actualMaterial;
            obj.AddComponent<MassCalc>();
            obj.GetComponent<Rigidbody>().Sleep();
        }
    }

	void Start ()
    { this.actualMaterial = ""; this.actualPoligon = ""; }

	void FixedUpdate ()
    {
        //Debug.Log(this.actualPoligon);
	}
}
