using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{

    public void PlayTheGame()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitTheGame()
    {
        Debug.Log("quit");
        Application.Quit();

    }


}