using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndScript : MonoBehaviour
{
    public GameObject failLevel;
    public GameObject successLevel;

    public void Start () {
        failLevel.SetActive(false);
        successLevel.SetActive(false);
    }

    public void FailLevel () {
        failLevel.SetActive(true);
    }

    public void SuccessLevel () {
        successLevel.SetActive(true);
    }
}
