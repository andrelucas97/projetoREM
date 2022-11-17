using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private string nomeTelaInicial;
    [SerializeField] private string nomeTelaJogo;

    public void Restart(){
        SceneManager.LoadScene(nomeTelaJogo);
                
    }

    public void Quit(){
        SceneManager.LoadScene(nomeTelaInicial);
    }
}
