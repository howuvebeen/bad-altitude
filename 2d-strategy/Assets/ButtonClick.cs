using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Player player;
    public Button netflixButton, gameButton, musicButton, storyButton;

    public void ClickNetflix () {
        player.TakeDamage(80);
        netflixButton.interactable = false;
        StartCoroutine(DelayNetflix());
    }

    IEnumerator DelayNetflix(){
        yield return new WaitForSeconds(10);  
        netflixButton.interactable = true;
    }

    public void ClickGame () {
        player.TakeBenefit(8);
        gameButton.interactable = false;
        StartCoroutine(DelayGame());
    }

    IEnumerator DelayGame(){
        yield return new WaitForSeconds(8);  
        gameButton.interactable = true;
    }

    public void ClickMusic () {
        player.TakeDamage(4);
        musicButton.interactable = false;      
        StartCoroutine(DelayMusic());

    }

    IEnumerator DelayMusic(){
        yield return new WaitForSeconds(4);  
        musicButton.interactable = true;
    }

    public void ClickStory () {
        player.TakeDamage(6);
        storyButton.interactable = false;
        StartCoroutine(DelayStory());
    }

    IEnumerator DelayStory(){
        yield return new WaitForSeconds(6);  
        storyButton.interactable = true;
    }

}
