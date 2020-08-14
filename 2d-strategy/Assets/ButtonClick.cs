using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public Player player;

    public void ClickNetflix () {
        player.TakeDamage(10);
    }

    public void ClickGame () {
        player.TakeBenefit(8);
    }

    public void ClickMusic () {
        player.TakeDamage(4);
    }

    public void ClickStory () {
        player.TakeDamage(5);
    }

}
