using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< HEAD

public class MainMenu : MonoBehaviour
{
=======
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text highscoreText;
    void Start()
    {
        highscoreText.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("Highscore", 0)).ToString();
    }
>>>>>>> ebc637f... Testing on new computer, added highscore function
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }   

    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
