using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceBackgroundMusic;
    public AudioClip[] backgroundmusic; 

    void Start()
    {
        AudioClip backgroundmusicthis = backgroundmusic[0];
        audioSourceBackgroundMusic.clip = backgroundmusicthis;
        audioSourceBackgroundMusic.Play();
    }
}
