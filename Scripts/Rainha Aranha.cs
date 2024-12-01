
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainha Aranha : MonoBehaviour
{
    void Update()
    {
         RainhaAranha.Colisão();
         RainhaAranha.Movimentação();
    }
    

    public class RainhaAranha
    {
       public Vector3 Pos;

        void Colisão()
        {
            if (colisão.gameObject.CompareTag("Jogador"))
            {                       
                Pos.z -= 3f;
                vidas--;
            }
        }

        void Movimentação()
        {
            Pos.z += 0.05f;
        }   
    }
    
}
