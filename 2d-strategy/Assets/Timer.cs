using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text textBox;
    public Player player;
    
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
    }

    public void ClickSleep () {
        timeStart -= 20;
        textBox.text = Mathf.Round(timeStart).ToString();
        player.TakeBenefit(30);
    }
}
