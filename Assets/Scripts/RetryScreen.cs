using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScreen : MonoBehaviour
{
<<<<<<< HEAD
    void OnTriggerEnter(Collider die)
    {
        Destroy(die.gameObject);
        SceneManager.LoadScene("RetryScreen");
=======

    void OnTriggerEnter(Collider die)
    {
        //Destroy(die.gameObject);
        SceneManager.LoadScene("RetryScreen");
        PlayerPrefs.SetFloat("Highscore", PlayerMovement.highscore);
>>>>>>> ebc637f... Testing on new computer, added highscore function
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
