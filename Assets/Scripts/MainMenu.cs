using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button soundButton, backgroundMusicButton;
    public static bool muteAudio = false;
    private static bool muteBackgroundMusic = false;
    private static MainMenu original;
    private BackgroundMusic backgroundMusic;
    void Start()
    {
        backgroundMusic = GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusic>();

        if (muteAudio == true)
        {
            soundButton.image.color = new Color32(150, 150, 150, 255);
        }

        else if (muteAudio == false)
        {
            soundButton.image.color = new Color32(255, 255, 255, 255);
        }

        if(muteBackgroundMusic == true)
        {
            backgroundMusic.PauseMusic();
            backgroundMusicButton.image.color = new Color32(150, 150, 150, 255);
        }

        else if(muteBackgroundMusic == false)
        {
            backgroundMusic.PlayMusic();
            backgroundMusicButton.image.color = new Color32(255, 255, 255, 255);
        }
    }

    private void Awake()
    {
        if(original != this)
        {
            if(original != null)
            {
                Destroy(original.gameObject);
            } 
            DontDestroyOnLoad(gameObject);
            original = this;
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Audio()
    {
        if(muteAudio == false)
        {
            soundButton.image.color = new Color32(150, 150, 150, 255);
            muteAudio = true;
        }

        else if(muteAudio == true)
        {
            soundButton.image.color = new Color32(255, 255, 255, 255);
            muteAudio = false;
        }
    }

    public void BackgroundMusic()
    {
        if(muteBackgroundMusic == false)
        {
            backgroundMusic.PauseMusic();
            backgroundMusicButton.image.color = new Color32(150, 150, 150, 255);
            muteBackgroundMusic = true;
        }

        else if(muteBackgroundMusic == true)
        {
            backgroundMusic.PlayMusic();
            backgroundMusicButton.image.color = new Color32(255, 255, 255, 255);
            muteBackgroundMusic = false;
        }
    }
}
