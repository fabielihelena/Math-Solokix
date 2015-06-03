using UnityEngine;
using System.Collections;

public class MassCalc : MonoBehaviour {
	
	void Start () {
		if(name.Equals("Cube"))
		{
			rigidbody.mass = CubicMass(transform.localScale,"");
		}
		else if(name.Equals("Cylinder"))
		{
			rigidbody.mass = CylinderMass(transform.localScale,"");
		}
	}

	float CubicMass(Vector3 Scale, string material)
	{
		switch (material) 
		{
			case "ferro":
				return Scale.x*Scale.y*Scale.z*3;
				break;
			default:
				return Scale.x*Scale.y*Scale.z*1;
				break;
		}
	}


	float CylinderMass(Vector3 Scale, string material)
	{
		switch (material) 
		{
			case "ferro":
				return (Mathf.PI*Scale.x*Scale.y*Scale.z)*3;
				break;
			default:
				return (Mathf.PI*Scale.x*Scale.y*Scale.z)*1;
				break;
		}
	}
}
