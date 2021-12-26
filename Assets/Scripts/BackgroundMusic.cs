using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource backgroundMusicAudioSource;
    private static BackgroundMusic instance;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        backgroundMusicAudioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (!backgroundMusicAudioSource.isPlaying)
        {
            backgroundMusicAudioSource.Play();
        } 
    }

    public void PauseMusic()
    {
        backgroundMusicAudioSource.Pause();
    }
}
