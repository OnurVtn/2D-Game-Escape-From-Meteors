using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text lastScoreText, highscoreText;
    public GameObject GameOverPanel;
    private int highscore;
    GainGolden GainGolden;
    
    void Start()
    {
        GainGolden = GameObject.FindGameObjectWithTag("Golden").GetComponent<GainGolden>();
        highscore = PlayerPrefs.GetInt("Highscore");
    }
  
    void Update()
    {
        lastScoreText.text = "S C O R E\n" + GainGolden.score;
        highscoreText.text = "H I G H S C O R E\n" + PlayerPrefs.GetInt("Highscore");

        if (GainGolden.score > highscore)
        {
            highscore = GainGolden.score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
        
        if(Time.timeScale == 0)
        {
            GameOverPanel.SetActive(true);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
        GainGolden.score = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
        GainGolden.score = 0;
    }
}
