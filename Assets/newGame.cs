﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class newGame : MonoBehaviour {


    public static newGame Instance { get; private set; }

    public InputField inputName;

    public string name;

    public int colorNumber;

    private void Awake()
    {
        if (Instance != null)
        {
            // DestroyImmediate(gameObject);
            return;
        }
        Instance = this;
        //  DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void selectColor(int i)
    {
        colorNumber = i;
    }

    public void eventPlay()
    {
        Logic logic = new Logic();
        logic.NewGame(inputName.text, colorNumber);
        SceneManager.LoadScene("Game");
    }

    public void changeName()
    {
        name = inputName.text;
    }
}
