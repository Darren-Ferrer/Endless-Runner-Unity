using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource niceTry;
    public AudioSource welcome;
    public AudioSource running;

    public void playNiceTry()
    {
        niceTry.play();
    }

    public void playWelcome()
    {
        welcome.play();
    }

    public void playRunning()
    {
        running.play();
    }
}
