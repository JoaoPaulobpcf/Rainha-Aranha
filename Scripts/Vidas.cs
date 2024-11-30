using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vidas : MonoBehaviour 
{
    public Jogador.Personagem JogPersonagem;

    
    private TextMeshPro txtVidas;

    void Start()
    {    
        txtVidas = GetComponent<TextMeshPro>();
    }

    void Update()
    {        
        ExibirVidas();
    }

    private void ExibirVidas()
    {
        if (JogPersonagem != null)
        {     
            txtVidas.SetText("Vidas: " + JogPersonagem.vidas);
        }
    }
}

