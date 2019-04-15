using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instancia; // PADRÃO DE PROJETO SINGLETON
    public Text pontos;
    public GameObject obj;
    public Transform pos;
    public float coletaveis;

    // OCORRE ANTES DO START
    private void Awake()
    {
        if (instancia == null)  // VERIFICA SE JA EXISTE UMA INSTANCIA
        {
            instancia = this;
        }
        else if (instancia != this) // DESTROI ANTES DE CRIAR SE JA EXISTIR UMA INSTANCIA
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(obj, pos);
        }
    }

    public void atualizaPontos(float inc)
    {
        coletaveis += inc;
        pontos.text = "Pontos: " + coletaveis;
    }
}
