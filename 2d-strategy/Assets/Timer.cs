using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public float timeSlider = 0;

    public Text textBox;
    public Button sleepButton;
    public Slider slider;

    public Player player;
    public HealthBar healthBar;
    public EndScript endScript;

    
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
        sleepButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
    
        if (slider.value <= 25) {
            timeSlider += Time.deltaTime;
            if (timeSlider > 5){
                sleepButton.interactable = true;
                timeSlider = 0;
            } 
        } 
        
        Debug.Log(timeStart);
        if (timeStart <= 0){
            endScript.SuccessLevel();
        }
    }

    public void ClickSleep () {
        timeStart -= 20;
        textBox.text = Mathf.Round(timeStart).ToString();
        player.TakeBenefit(30);
        sleepButton.interactable = false;
        timeSlider = 0;
    }

}
