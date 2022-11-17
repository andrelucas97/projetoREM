using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{

    //public GameObject sanidade;
    public GameObject fantasma;
    public Transform alvo;
    private float velMov;
    private float distanciaMinima;
    public double perdaSanidade;

    public Rigidbody rigidbody2;

    void Start()
    {
        velMov = 50;
        distanciaMinima = 3;

        //perdaSanidade = sanidade.GetComponent<Sanidade>().pontoSanidade;
    }

    void Update()
    {

        if (fantasma.activeInHierarchy == false){
            perdaSanidade = 0;
        }    

        Vector3 posicaoAlvo = this.alvo.position;
        Vector3 posicaoAtual = this.transform.position;

        float distancia = Vector3.Distance(posicaoAtual, posicaoAlvo);
        if (distancia >= this.distanciaMinima){
            Vector3 direcao = posicaoAlvo - posicaoAtual;
            direcao = direcao.normalized;

            this.rigidbody2.velocity = (this.velMov * direcao);
        } else {
            this.rigidbody2.velocity = Vector3.zero;     

            if (fantasma.activeInHierarchy == true){
                perdaSanidade = 0.1;
            }

    
        }

        
    

    }
}
