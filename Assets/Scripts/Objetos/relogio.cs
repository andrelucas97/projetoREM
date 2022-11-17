using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class relogio : MonoBehaviour
{
    public GameObject rachadura;
    public GameObject espelhoQuebrado;

    public GameObject sustoMonstro;
    public GameObject televisao;
    public GameObject fantasma1;
    public GameObject fantasma2;
    public GameObject fantasmaEspelho;
    public GameObject monstroCadeira;

    public GameObject luzesLustre;
    public GameObject luzAbajur;
    public GameObject luzCorredor;


    public GameObject somPortaRangendo;
    public GameObject somPortaBatendo;
    public GameObject somEspelhoQuebrado;
    public GameObject somChuva;
    public GameObject somDespertador;
    public GameObject somAmbiente;


    public GameObject telaJogo;
    public GameObject telaFinalJogo;


    public Animator _animator;
    public Animator _animatorCadeira;
    public Animator _animatorLuzes;
    public Animator _animatorLuzesIntensity;
    public Animator _animatorSol;

    public Text timeRelogio_txt;
    public float hora;
    public float min;


    void Start()
    {
        somEspelhoQuebrado.SetActive(false);
        monstroCadeira.SetActive(false);
        somDespertador.SetActive(false);
        somAmbiente.SetActive(false);

        sustoMonstro.SetActive(false);
        rachadura.SetActive(false);

    }

    void Update()
    {

        min = min + Time.deltaTime/2;
        
        timeRelogio_txt.text = hora.ToString("00") + ":" + min.ToString("00");

        if ((int)min == 59){
            min = 0;
            hora = hora + 1;
        }

        if ((int)hora == 23){
            hora = 0;
        }

        if (((int)hora == 00) & ((int)min == 03)){
            somPortaRangendo.SetActive(true);
            _animator.SetBool("Fechar", false);   
            _animator.SetBool("Abrir", true);        
        }      

        if (((int)hora == 0) & ((int)min == 10)){
            rachadura.SetActive(true);            
        }

        if (((int)hora == 00) & ((int)min == 23)){
            luzCorredor.SetActive(false);
        }

        if (((int)hora == 00) & ((int)min == 24)){
            luzCorredor.SetActive(true);
            sustoMonstro.SetActive(true);
        }

        if (((int)hora == 0) & ((int)min == 30)){
            _animatorLuzesIntensity.SetBool("luz-intensity", true);
        }

        if (((int)hora == 00) & ((int)min == 40)){
            _animatorLuzesIntensity.SetBool("luz-intensity", false);
            televisao.SetActive(true);
        }

        if (((int)hora == 00) & ((int)min == 50)){
            fantasma1.SetActive(true);
        }

        if (((int)hora == 01) & ((int)min == 10)){
            fantasma2.SetActive(true);
        }

        if (((int)hora == 00) & ((int)min == 57)){
            _animator.SetBool("Abrir", false);
            _animator.SetBool("Fechar", true);
            somPortaRangendo.SetActive(false);
            somPortaBatendo.SetActive(true);

        }

        if (((int)hora == 01) & ((int)min == 14)){
            somPortaBatendo.SetActive(false);
            somPortaRangendo.SetActive(true);
            _animator.SetBool("Fechar", false);
            _animator.SetBool("Abrir", true);
        }

        if (((int)hora == 01) & ((int)min == 30)){
            fantasmaEspelho.SetActive(true);
        }

        if (((int)hora == 01) & ((int)min == 57)){
            _animator.SetBool("Abrir", false);
            _animator.SetBool("Fechar", true);
            somPortaRangendo.SetActive(false);
            somPortaBatendo.SetActive(true);

        }


        if (((int)hora == 02) & ((int)min == 09)){
            _animatorLuzes.SetBool("Piscando", true);

        }       
        if(((int)hora == 02) & ((int)min == 10)){
            _animatorLuzes.SetBool("Piscando", false);
            monstroCadeira.SetActive(true);


        }
      
        if (((int)hora == 02) & ((int)min == 12)){
            _animatorCadeira.SetBool("MexerCadeira", true);
        }

        if(((int)hora == 02) && ((int)min == 30)){
            somEspelhoQuebrado.SetActive(true);
            espelhoQuebrado.SetActive(true);

        }

        if(((int)hora == 06) && ((int)min == 00)){
            _animatorSol.SetBool("amanheceu", true);
            somAmbiente.SetActive(true);


            telaJogo.SetActive(false);
            somChuva.SetActive(false);

            somDespertador.SetActive(true);
            telaFinalJogo.SetActive(true);

        }
    }

    

}
