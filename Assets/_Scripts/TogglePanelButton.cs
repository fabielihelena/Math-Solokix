using UnityEngine;
using System.Collections;

public class TogglePanelButton : MonoBehaviour {

    //object main, irá definir o material do cubo criado
    public Main main;

    //pegando o componente de "GameController"
    void Start()
    { this.main = GameObject.Find("GameController").GetComponent<Main>(); }

    //função que modificara a string "actualCube", para que ela seja igual ao material clicado
    public void ChangeMaterial()
    { main.actualMaterial = this.name; }

    public void ChangePoligon()
    { main.actualPoligon = this.name; }

    //debug para verificar qual material foi clicado
    void FixedUpdate()
    { }

    //inverter o estado ativo/desativo de um painel
	public void TogglePanel (GameObject panel)
	{ panel.SetActive(!panel.activeSelf); }

    //ativar painel
    public void ActivePanel (GameObject painel)
    { painel.SetActive(true); }

    //desativar painel
    public void DesablePanel (GameObject painel)
    { painel.SetActive(false); }
}
