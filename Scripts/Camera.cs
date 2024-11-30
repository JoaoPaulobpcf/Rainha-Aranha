using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Jogador;
    public float Vel;
    public float VelR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Jogador != null)
        {
            transform.position = Vector3.Lerp(transform.position, Jogador.transform.position, Time.deltaTime * Vel);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Jogador.transform.rotation, Time.deltaTime * VelR);
        }
    }
}

