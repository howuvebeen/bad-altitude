using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndScript : MonoBehaviour
{
    public GameObject failLevel;

    public void FailLevel () {
        failLevel.SetActive(true);
    }
}
