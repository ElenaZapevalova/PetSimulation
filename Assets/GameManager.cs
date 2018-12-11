using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    float timer;
    int minutes;
    public int lastMinute = 0;


    public GameObject hungerText;
    public GameObject happyText;
    public GameObject healthText;
    public GameObject energyText;
    public GameObject nameText;
    public GameObject ageText;

    public GameObject[] chrachterList;
    public GameObject character;

    public GameObject menuCanvas;

    public GameObject theEnd;

    public int colorNumber;    

    void Start () {
        timer = 0;       
        menuCanvas.SetActive(false);
        theEnd.SetActive(false);
        string typeGame = MenuManager.Instance.typeGame;
        switch (typeGame)
        {
            case ("new"):
                createCharacter(newGame.Instance.colorNumber);
                StatsValuesUpdate("new",null);
                    break;
            case ("load"):
                Logic logic = new Logic();
                StatsValuesUpdate("load", logic.Load());
                break;
        }
    
    }

	void Update () {
        timerCalc();

        if (Input.GetMouseButtonUp(0) && theEnd.activeSelf)
        {
            SceneManager.LoadScene("Menu");
        }
    }

   void createCharacter(int i)
    {
        if (character)
            Destroy(character);
        character = Instantiate(chrachterList[i], chrachterList[i].transform.position, Quaternion.identity) as GameObject;
        colorNumber = i;
    }

    void timerCalc()
    {
        timer += Time.deltaTime;
        minutes = (int) timer / 60;
    
       if (minutes % 1 == 0 && lastMinute != minutes)
        {
            Debug.Log("tic " + minutes);
            StatsDown();
            lastMinute = minutes;
        }
    }

    public void StatsDown()
    {
       Pet pet = new Pet();

       string hunger = hungerText.GetComponent<Text>().text;
       string happy = happyText.GetComponent<Text>().text;
       string health = healthText.GetComponent<Text>().text;
       string energy = energyText.GetComponent<Text>().text;
       if (health == "0") Die();
        
        string[] values = new string[] {
            pet.statsDown(hunger,1,6),
            pet.statsDown(happy, 1, 5),
            pet.statsDown(health, 1, 4),
            pet.statsDown(energy, 1, 3),
            nameText.GetComponent<Text>().text,
            ageText.GetComponent<Text>().text,
            colorNumber.ToString()
        };
        StatsValuesUpdate("load", values);


    }

    public void Die(){       
            theEnd.SetActive(true);
            System.IO.File.Delete("settings.txt");
    }

    public void StatsValuesUpdate(string type, string [] value)    {

        switch (type)
        {
            case ("new"):
                hungerText.GetComponent<Text>().text = "100";
                happyText.GetComponent<Text>().text = "100";
                healthText.GetComponent<Text>().text = "100";
                energyText.GetComponent<Text>().text = "100";
                ageText.GetComponent<Text>().text = "0";
                nameText.GetComponent<Text>().text = newGame.Instance.name;
                break;
            case ("load"):
                hungerText.GetComponent<Text>().text = value[0];
                happyText.GetComponent<Text>().text = value[1];
                healthText.GetComponent<Text>().text = value[2];
                energyText.GetComponent<Text>().text = value[3];
                nameText.GetComponent<Text>().text = value[4];
                ageText.GetComponent<Text>().text = value[5];
                colorNumber = Int32.Parse(value[6]);
                createCharacter(colorNumber);
                if (value[2] == "0") Die();               
                break;
            case ("hunger"):
                hungerText.GetComponent<Text>().text = value[0];
                break;
            case ("happy"):
                happyText.GetComponent<Text>().text = value[0];
                break;
            case ("health"):
                healthText.GetComponent<Text>().text = value[0];
                break;
            case ("energy"):
                energyText.GetComponent<Text>().text = value[0];
                break;

        }

    }

    public void buttonBehavior(int i) { 

        Pet pet = new Pet();

        string value;

        switch (i)
        {
            case (6):
                Debug.Log("6 hunger");
              value=  pet.statsUp(hungerText.GetComponent<Text>().text, i);
                StatsValuesUpdate("hunger", new string[] { value });
                break;
            case (5):
                Debug.Log("5 happy");
                 value = pet.statsUp(happyText.GetComponent<Text>().text, i);
                StatsValuesUpdate("happy", new string[] { value });
                break;
            case (4):
                Debug.Log("4 health");
                value = pet.statsUp(healthText.GetComponent<Text>().text, i);
                StatsValuesUpdate("health", new string[] { value });
                break;
            case (3):
                Debug.Log("3 energy");
                 value = pet.statsUp(energyText.GetComponent<Text>().text, i);
                StatsValuesUpdate("energy", new string[] { value });
                break;
            case (0):
                menuCanvas.SetActive(true);
                break;

        }
    }

    public void buttonMenuBehavior(int i)
    {
        Logic logic = new Logic();

        string hunger = hungerText.GetComponent<Text>().text;
        string happy = happyText.GetComponent<Text>().text;
        string health = healthText.GetComponent<Text>().text;
        string energy = energyText.GetComponent<Text>().text;

        switch (i)
        {
            case (0):              
                SceneManager.LoadScene("Menu");
                break;
            case (1):
                menuCanvas.SetActive(false);
                break;
            case (2):
                  logic.Save("Jelly", "5", hunger, happy,health,energy, colorNumber);
                break;
            case (3):
                logic.Save("JoJo", "35", hunger, happy, health, energy, colorNumber);
                SceneManager.LoadScene("Menu");
                break;                
        }
    }

}
