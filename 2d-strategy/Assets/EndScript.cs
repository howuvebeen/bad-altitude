using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndScript : MonoBehaviour
{
    public GameObject failLevel;
    public GameObject successLevel;

    public LevelScript levelScript;
    public int sceneIndex, levelPassed;

    public void Start () {
        failLevel.SetActive(false);
        successLevel.SetActive(false);

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void FailLevel () {
        failLevel.SetActive(true);
        StartCoroutine(BackToLevel());
    }

    public void SuccessLevel () {
        successLevel.SetActive(true);
        if (sceneIndex >= levelPassed){
            levelPassed = sceneIndex;
            levelScript.UnlockLevel(levelPassed);
        }
        StartCoroutine(BackToLevel());
    }

    IEnumerator BackToLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
