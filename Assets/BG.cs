using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float velocidade = 1.2f;
    public float reposicao = 51.1f;

    public Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position ;
         
    }

    
    void Update()
    {
        float novaPosicao = Mathf.Repeat(Time.time * velocidade ,reposicao);
        transform.position = posicaoInicial + Vector3.left * novaPosicao;
    }
    
    
}
