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
        levelOneButton.interactable = true;
        levelTwoButton.interactable = false;
        levelThreeButton.interactable = false;
    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
}
