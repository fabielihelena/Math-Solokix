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
    

    /*
    public void InstatiateCostume(GameObject obj, Vector3 vector3, Texture3D texture, string tag)
    { 
        Instantiate(obj,vector3, this.transform.rotation);
        obj.tag = tag;
    }
    */


    public void SpawnObject()
    {
        Vector3 t = actualPuzzle.transform.FindChild("InstantiateSPoint").position;
        GameObject obj = new GameObject();
        #region Select Material
        if (actualPoligon.Equals("Cubo"))
        {
            switch (actualMaterial)
            {

                case "Ferro":
                    obj = shapes[2];
                    break;
                case "Madeira":
                    obj = shapes[1];
                    break;
                case "Ouro":
                    obj = shapes[5];
                    break;
                case "Poliestireno":
                    obj = shapes[4];
                    break;
                case "Chumbo":
                    obj = shapes[7];
                    break;
                case "Diamante":
                    obj = shapes[6];
                    break;
                case "Mercurio":
                    obj = shapes[3];
                    break;
                default:
                    obj = shapes[0];
                    break;
            }
        }
        #endregion

        int g = Mathf.RoundToInt(actualQuantity / 3);
        while (g > 0)
        {
            for (int i = 0; i < 3; i++)
                {
                    if (totalQuantity < actualQuantity)
                    {
                        obj.AddComponent<MassCalc>();
                        obj.transform.localScale = new Vector3(actualSize, actualHigh, actualSize);
                        obj.transform.position = new Vector3(t.x, t.y  /*+(actualHigh*(g-1))*/, t.z - (actualSize * i));
                        GameObject o = (GameObject)Instantiate(obj);
                        o.transform.parent = actualPuzzle.transform;
                        totalQuantity++;
                        g--;
                    }
                }

            }
        }
        void Start ()
        { this.actualMaterial = ""; this.actualPoligon = ""; }

	    void FixedUpdate ()
        {
            //Debug.Log(this.actualPoligon);
	    }
    }


