using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelScript : MonoBehaviour
{
    
    public Button levelOneButton, levelTwoButton, levelThreeButton;
    
    // Update is called once per frame
    void Start()
    {
        levelTwoButton.interactable = false;
        levelThreeButton.interactable = false;
    }

    public void UnlockLevel(int level){
        switch(level){
            case 1:
                levelOneButton.interactable = true;
                break;
            case 2:
                levelTwoButton.interactable = true;
                levelThreeButton.interactable = true;
                break;
            case 3:
                levelTwoButton.interactable = true;
                levelThreeButton.interactable = true;
                levelThreeButton.interactable = true;
                break;
        }
    }

    public void ClickLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
