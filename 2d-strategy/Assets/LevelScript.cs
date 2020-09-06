using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelScript : MonoBehaviour
{
    
    public Button levelOneButton, levelTwoButton, levelThreeButton;
    
    public EndScript endScript;

    // Update is called once per frame
    void Start()
    {
        levelTwoButton.interactable = false;
        levelThreeButton.interactable = false;

        endScript.levelPassed = PlayerPrefs.GetInt("LevelPassed");

        switch(endScript.levelPassed){
            case 1:
                levelOneButton.interactable = true;
                levelTwoButton.interactable = false;
                levelThreeButton.interactable = false;
                break;
            case 2:
                levelTwoButton.interactable = true;
                levelTwoButton.interactable = true;
                levelThreeButton.interactable = false;
                break;
            case 3:
                levelThreeButton.interactable = true;
                levelTwoButton.interactable = true;
                levelThreeButton.interactable = true;
                break;
        }
    }

    public void ClickLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
