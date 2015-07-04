using UnityEngine;
using System.Collections;

public class TogglePanelButton : MonoBehaviour {

	public void TogglePanel (GameObject panel)
	{ panel.SetActive(!panel.activeSelf); }

    public void CreateCube(GameObject panel)
    {  }
}
