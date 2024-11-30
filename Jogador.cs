using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Personagem personagem;
    // Start is called before the first frame update
    void Start()
    {
        personagem = new Personagem(this);
    }

    // Update is called once per frame
    void Update()
    {
        personagem.Movimento();
    }

    public class Personagem
    {
        public Vector3 Pos;
        private Jogador J;


        public Personagem(Jogador jogador)
        {
            J = jogador;
            Pos = J.transform.position;
        }

        public void Movimento()
        {
           

            if (Input.GetKey(KeyCode.A))
            {
                Pos.z -= 0.08f;
            }

            if (Input.GetKey(KeyCode.D))
            {
                Pos.z += 0.08f;
            }

            if (Input.GetKey(KeyCode.W))
            {
                Pos.x -= 0.08f;
            }
            J.transform.position = Pos;
        }
    }
}
                                            