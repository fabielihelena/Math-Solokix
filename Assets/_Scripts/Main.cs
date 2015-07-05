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
    public float totalQuantity = 0;
    
    public void SpawnObject()
    {
        Vector3 t = actualPuzzle.transform.FindChild("InstantiateSPoint").position;
        int g =actualQuantity;
            for (int i = 0; i < 3; i++)
            {
                if (actualPoligon.Equals("Cubo"))
                {
                    Debug.Log("oioio");
                    GameObject obj = shapes[0];
                    obj.SetActive(true);
                    obj.tag = actualMaterial;
                    obj.AddComponent<MassCalc>();
                    obj.GetComponent<Rigidbody>().useGravity = false;
                    obj.GetComponent<BoxCollider>().enabled = false;
                    obj.transform.localScale = new Vector3(actualSize, actualHigh, actualSize);
                    obj.transform.position = new Vector3(t.x, t.y, t.z - (actualSize * i));
                    Instantiate(obj);
                    g--;
                }
                if (g >= 0) break;
            }
    }

	void Start ()
    { this.actualMaterial = ""; this.actualPoligon = ""; }

	void FixedUpdate ()
    {
        //Debug.Log(this.actualPoligon);
	}
}
