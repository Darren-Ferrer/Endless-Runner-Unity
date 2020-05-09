using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScreen : MonoBehaviour
{

    void OnTriggerEnter(Collider die)
    {
        SceneManager.LoadScene("RetryScreen");
        PlayerPrefs.SetFloat("Highscore", PlayerMovement.highscore);
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void toGame()
    {
        SceneManager.LoadScene(1);
    }
}
