using System;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;




public class MenuManager : MonoBehaviour {
    
    public static MenuManager Instance { get; private set; }
    public string typeGame;

    public GameObject menuWthoutLoad;
    public GameObject menuLoad;

    private void Awake()
    {
        if (Instance != null)
        {
    
            return;
        }
        Instance = this;
    }

    void Start (){

        if(System.IO.File.Exists("settings.txt")){
            menuLoad.SetActive(true);
            menuWthoutLoad.SetActive(false);
        }else{
             menuLoad.SetActive(false);
             menuWthoutLoad.SetActive(true);
        }
    }

    void Update () {
		if(Input.GetMouseButtonUp (0)){
		
		}
	}

	public void buttonBehavior(int i){
        switch (i){
            case (0):          
                typeGame = "new";
                SceneManager.LoadScene("newGame");            
                break;
            case (1):
                typeGame = "load";
                SceneManager.LoadScene("Game");
			break;
			case(2):
			    Application.Quit();
			break;
		}
	}
}
