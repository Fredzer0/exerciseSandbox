using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBouton : MonoBehaviour
{
    [SerializeField] private Transform panelConfirmation;
    public void OnPause(){
        if(Time.timeScale > 0.5){

            //a faire, désactivé controle
            //pause les son

            Time.timeScale = 0.0f;
        }
        else{
            Time.timeScale = 1.0f;
        }
    }

    public void OnTryQuit(){
        panelConfirmation.gameObject.SetActive(true);
    }

    public void OnQuit(){
        Application.Quit();
        Debug.Log("bye byeeeeee");
    }

    public void NoQuit(){
        panelConfirmation.gameObject.SetActive(false);
    }

}
