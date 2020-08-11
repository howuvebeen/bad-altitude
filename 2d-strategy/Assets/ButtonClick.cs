using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public void ClickNetflix () {
        TakeDamage(10);
    }

    public void ClickGame () {
        TakeBenefit(8);
    }

    public void ClickMusic () {
        TakeDamage(4);
    }

    public void ClickStory () {
        TakeDamage(5);
    }
}
