using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuPrincipal;
    [SerializeField] private GameObject painelOpcoes;

    void start(){
        painelOpcoes.SetActive(false);
        painelMenuPrincipal.SetActive(true);


    }

    public void Jogar(){
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void AbrirComoJogar(){
        painelMenuPrincipal.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharComoJogar(){
        painelMenuPrincipal.SetActive(true);
        painelOpcoes.SetActive(false);
    }

    public void SairJogo(){
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
