using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vidas : MonoBehaviour 
{
    public Jogador.Personagem.Vidas JogVidas;

    
    private TextMeshPro txtVidas;

    void Start()
    {    
        txtVidas = GetComponent<TextMeshPro>();
    }

    void Update()
    {        
        Vd.ExibirVidas();
    }
    
    public class Vd
    {
        public void ExibirVidas()
        {
            if (JogVidas != null)
            {
                txtVidas.SetText("Vidas: " + JogVidas);
            }

            if (vidas == 0) //Quando acabarem as vidas, a cena mudará para simbolizar o fim do jogo
            {
                SceneManager.LoadScene("FimJogo");
            }
        }
    }
    
}

