using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("StageOne");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
