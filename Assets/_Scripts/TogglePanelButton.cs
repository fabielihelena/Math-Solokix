using UnityEngine;
using System.Collections;

public class TogglePanelButton : MonoBehaviour {

	public void TogglePanel (GameObject panel)
	{ panel.SetActive(!panel.activeSelf); }

    public void CreateCube(GameObject panel)
    {  }

    public void ActivePanel (GameObject painel)
    { painel.SetActive(true); }
    public void DesablePanel (GameObject painel)
    { painel.SetActive(false); }
}
