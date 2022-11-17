using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class piscandoOlho : MonoBehaviour
{

    public GameObject sanidade;
    public GameObject sanidadeF;
    //public double aumentoSanidade;
    public double fantasmaSanidade;


    public GameObject monster;
    public GameObject monstroCadeira;
    public GameObject fantasmaEspelho;
    public GameObject fantasma2;
    public GameObject fantasma3;


    public GameObject rachadura;
    public GameObject televisao;
    public GameObject espelhoQuebrado;

    public GameObject somEspelhoQuebrado;


    public Animator _animatorCadeira;

    public int speed = 0;

    public Canvas UICanvas;

    void Start()
    {
        fantasmaSanidade = sanidadeF.GetComponent<Fantasma>().perdaSanidade;

        //aumentoSanidade = sanidade.GetComponent<Sanidade>().pontoSanidade;
    }

    void Update()
    {

        //aumentoSanidade = sanidade.GetComponent<Sanidade>().pontoSanidade;

        transform.Translate (0, speed*Time.deltaTime, 0);

        if (Input.GetKey (KeyCode.F)){
            speed = -2500;

            if (transform.position.y <= 500){
                //aumentoSanidade += .1;    
                speed = 0;
                //if (aumentoSanidade >= 100){
                    //aumentoSanidade = 100;
                //}

                if ((monster) == true){
                    monster.SetActive(false);
                }

                if (rachadura == true){
                    rachadura.SetActive(false);
                }

                if (fantasma2 == true){
                    fantasma2.SetActive(false);

                }

                if (fantasma3 == true){
                    fantasma3.SetActive(false);

                }

                if (televisao == true){
                    televisao.SetActive(false);

                }

                if (fantasmaEspelho == true){
                    fantasmaEspelho.SetActive(false);
                }

                if (monstroCadeira == true){
                    monstroCadeira.SetActive(false);
                    _animatorCadeira.SetBool("MexerCadeira", false);
                }

                if (espelhoQuebrado == true){
                    espelhoQuebrado.SetActive(false);
                    somEspelhoQuebrado.SetActive(false);
                }         
            }

        }
        else{
            speed = 2500;
            
             if (transform.position.y >= 2000){
                speed = 0;
             }

        }
    }
}
