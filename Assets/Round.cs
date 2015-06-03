using UnityEngine;
using System.Collections;

public class Round : MonoBehaviour 
{
	public float m = 2;

	void Update () 
	{
		if (Input.GetMouseButton(1) && Input.GetAxis("Mouse X") > 0) 
		{
			transform.Rotate(new Vector3(0,m,0));
		}
		else if (Input.GetMouseButton(1) && Input.GetAxis("Mouse X") < 0) 
		{
			transform.Rotate(new Vector3(0,-m,0));
		}

		if (Input.GetAxis ("Mouse ScrollWheel")>0 && Camera.main.fieldOfView > 20) 
		{
			Camera.main.fieldOfView += -m;
		}
		else if (Input.GetAxis ("Mouse ScrollWheel")<0 && Camera.main.fieldOfView < 80) 
		{
			Camera.main.fieldOfView += m;
		}
		if (Input.GetAxis ("Mouse Y") > 0 && Input.GetMouseButton (1)) 
		{
			transform.Rotate (new Vector3(-m,0,0));
		}
	}
}
