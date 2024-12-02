using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class Jogador : MonoBehaviour
{
    private Personagem personagem;


    void Start()
    {
        personagem = new Personagem(this);
    }

    
    void Update()
    {
       
        personagem.Movimento();
    }

    public class Personagem
    {
        public Vector3 Pos;
        private Jogador J;
        public int vidas = 3;
        bool colObs = false; // Colisão do jogador com obstáculos (com a exceção de buracos)

        public Personagem(Jogador jogador)
        {
            J = jogador;
            Pos = J.transform.translate;
        }
        public void OnCollisionEnter(Collision colisão) // Colisão do jogador 
        {
            if (colisão.gameObject.CompareTag("Obstáculo")) // Colisão do jogador com Obstáculos diminuirá a vida do jogador
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
            if (colisão.gameObject.CompareTag("Buraco"))
            {
                Pos.x = 0f;
                Pos.y = 0f;
                Pos.z = 0f;
                vidas--;
            }
        }

        public void Movimento()
        {
            if (colObs == false)
            {
                Pos.z += 0.05f;
                else
            	{
                    Pos.z -= 0.05f;
            	}
            }
            

            if (Input.GetKey(KeyCode.S))
            {
                Pos.z -= 0.05f;
            }

            if (Input.GetKey(KeyCode.D))
            {
                Pos.x += 0.05f;
            }

            if (Input.GetKey(KeyCode.A))
            {
                Pos.x -= 0.05f;
            }

            if (Input.GetKey(KeyCode.Space))
            {             
                Pos.y += 0.10f;
            }
      
           J.transform.translate = Pos;
        }
    }
}
