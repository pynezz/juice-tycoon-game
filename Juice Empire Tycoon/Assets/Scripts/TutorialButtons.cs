using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialButtons : MonoBehaviour
{
    public GameObject welcomeScreen;

    public void Start()
    {
        //welcomeScreen.SetActive(true);
    }

    public void ExitButton()
    {
        welcomeScreen.SetActive(false);
    }

    public void StartPlaying()
    {
        welcomeScreen.SetActive(false);
    }
}
