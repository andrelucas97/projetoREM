using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sanidade : MonoBehaviour
{

    public GameObject sanidade;
    public GameObject sanidadeF;
    public GameObject rachadura;
    public GameObject fantasma;
    public GameObject fantasma1;
    public GameObject fantasma2;
    public GameObject fantasmaEspelho;
    public GameObject monstroCadeira;
    public GameObject televisao;

    // audios jogo
    
    public GameObject somMusica;
    public GameObject somCoracao;
    public GameObject somChuva;
    public GameObject somTV;
    public GameObject somFantasma;
    public GameObject somFantasma1;
    public GameObject somFantasma2;
    public GameObject somFantasmaEspelho;

    public GameObject telaJogo;
    public GameObject menuMorte;


    public double pontoSanidade;
    public double perdaSanidade;

    public Image barraSanidade;

    //int vidaAtual;

    void Start()
    {
        pontoSanidade = 100;
        menuMorte.SetActive(false);

        somMusica.SetActive(false);
        somCoracao.SetActive(false);
        somChuva.SetActive(true);
        
        Time.timeScale = 1;


    }

    void Update()
    {
        Vector3 barraSanidadeScale = barraSanidade.rectTransform.localScale;
        barraSanidadeScale.x = (float)pontoSanidade / 100;
        barraSanidade.rectTransform.localScale = barraSanidadeScale;

        //pontoSanidade = sanidade.GetComponent<piscandoOlho>().aumentoSanidade;
        perdaSanidade = sanidadeF.GetComponent<Fantasma>().perdaSanidade;
        
        if ( rachadura.activeInHierarchy == true){
            pontoSanidade -= 0.03;
            if (pontoSanidade <= 50){
                pontoSanidade -= 0.1;
            }
        }

        if ( (fantasma.activeInHierarchy) || (fantasma2.activeInHierarchy) || (fantasmaEspelho.activeInHierarchy)  == true){
            pontoSanidade -= 0.03;
            if (pontoSanidade <= 50){
                pontoSanidade -= 0.1;
            }
        }

        if (televisao.activeInHierarchy == true){
            pontoSanidade -= 0.05;
        }

        if (fantasma1.activeInHierarchy == false){
            perdaSanidade = 0;
        }

        if (pontoSanidade <= 40){
            somCoracao.SetActive(true);
        }

        pontoSanidade = pontoSanidade - perdaSanidade;

        if (pontoSanidade <= 0){
            pontoSanidade = 0;


            somCoracao.SetActive(false);
            somChuva.SetActive(false);
            somFantasma.SetActive(false);
            somFantasma1.SetActive(false);
            somFantasma2.SetActive(false);
            somFantasmaEspelho.SetActive(false);
            somTV.SetActive(false);
            somMusica.SetActive(true);



            telaJogo.SetActive(false);
            menuMorte.SetActive(true);
            Time.timeScale = 0;
            

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="ursinho")
        {
            pontoSanidade -= 20;
            Destroy(collision.gameObject);

        }
    }
}
