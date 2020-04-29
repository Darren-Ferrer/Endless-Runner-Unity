using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScreen : MonoBehaviour
{
    void OnTriggerEnter(Collider die)
    {
        Destroy(die.gameObject);
        SceneManager.LoadScene("RetryScreen");
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
