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
        niceTry.Play();
    }

    public void playWelcome()
    {
        welcome.Play();
    }

    public void playRunning()
    {
        running.Play();
    }
}
