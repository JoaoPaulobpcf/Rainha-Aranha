
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainha Aranha : MonoBehaviour
{
    void Update()
    {
         RainhaAranha.Colis�o();
         RainhaAranha.Movimenta��o();
    }
    

    public class RainhaAranha
    {
       public Vector3 Pos;

        void Colis�o()
        {
            if (colis�o.gameObject.CompareTag("Jogador"))
            {                       
                Pos.z -= 3f;
                vidas--;
            }
        }

        void Movimenta��o()
        {
            Pos.z += 0.05f;
        }   
    }
    
}
