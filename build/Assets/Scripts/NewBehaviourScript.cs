using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStartGame(int hahaha)
    {
        if (hahaha == 1)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene(hahaha);

    }
    public void quitGame()
    {
        Application.Quit();
    }
}
