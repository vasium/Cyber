using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffects : MonoBehaviour
{
    public AudioSource[] sounds;
    AudioSource sound1;
    AudioSource sound2;

    void Start()
    {
        sounds = GetComponents<AudioSource>();
        sound1 = sounds[0];
        sound2 = sounds[1];
    }

    public void Sound01()
    {
        sound1.Play();
    }

    public void Sound02()
    {
        sound2.Play();
    }
}
