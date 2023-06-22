using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeuDeFundo : MonoBehaviour
{
    // Movimentar na Horizontal

    public float velocidade = 1.0f;
    public float reposicao = 18f;
    public Vector3 posicaoInicial;


    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        float novaPosicao = Mathf.Repeat(Time.time*velocidade , reposicao);
        transform.position = posicaoInicial + Vector3.right*novaPosicao;
    }
}
