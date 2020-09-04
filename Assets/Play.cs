using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public void PlayIntro ()
    {
        SceneManager.LoadScene("Intro");
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
}
