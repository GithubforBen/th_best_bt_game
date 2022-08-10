using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void PlayGame () 
    {
        SceneManager.LoadScene(2);
        FindObjectOfType<AudioManager>().Play("Test_Start");
    }

    public void Options() 
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
