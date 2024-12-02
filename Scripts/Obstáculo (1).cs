using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Obstáculo : MonoBehaviour
{
    void Update()
    {
        Obs.ObsColisao();
    }
 
    public class Obs
    {

    void ObsColisao()
    {
        public void OnCollisionEnter(Collision colisão) // Colisão do jogador 
        {
            if (colisão.gameObject.CompareTag("Jogador") gameObject.CompareTag("Obstáculo")) // Colisão do jogador com Obstáculos diminuirá a vida do jogador
            {
                if (Pos.y < 2f) // Colisão do jogador com obstáculos enquanto estiver abaixo dessa coordenada no eixo y significa que a colisão é de frente com o obstáculo, neste caso ele não poderá seguir em frente a menos que saia da frente ou pule por cima
                {
                    colObs = true;
                }
                else
                {
                    colObs = false;
                }
            }

            if (colisão.gameObject.CompareTag("Jogador") && gameObject.CompareTag("Buraco")) // Colisão do jogador com o buraco o fará voltar para o início do mapa junto com a Rainha Aranha, desfazendo o progresso feito
            {
                Personagem.Pos.x = 0f;
                Personagem.Pos.y = 0f;
                Personagem.Pos.z = 0f;

                RainhaAranha.Pos.x = 0f;
                RainhaAranha.Pos.y = 0f;
                RainhaAranha.Pos.z = 0f;
                vidas--;
            }
        }
    }
}

