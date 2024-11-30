using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aranha : MonoBehaviour
{
    public Vector3 Pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Aranha(Jogador jogador)
    {
        A = jogador;
        Pos = A.transform.position;
    }
    public void Movimento()
    {
        Pos.z += 0.05f;
        A.transform.position = Pos;
    }
}
