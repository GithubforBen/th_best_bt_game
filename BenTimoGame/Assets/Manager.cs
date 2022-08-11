using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void PlayGame () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        FindObjectOfType<AudioManager>().Play("Test_Start");
    }
    public void Options() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Close() 
    {
        Application.Quit();
    }
    public void Menu () 
    {
        LoadScene(0);
    }




    public void LoadScene(int i) 
    {
        try
        {
            SceneManager.LoadScene(i);
        }
        catch (System.Exception)
        {
            Debug.LogError("Die Szene " + i + " existiert nicht!");
            throw;
        }
    }
    public void LoadNextScene() 
    {
        try
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        catch (System.Exception)
        {
            Debug.LogError("Die Szene existiert nicht!");
            throw;
        }
    }
}