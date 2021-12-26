using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainGolden : MonoBehaviour
{
    public static int score;
    public int gainScore;
    public Text scoreText;
    public AudioSource goldenSound;
    private MainMenu MainMenu;
    
    void Start()
    {
        MainMenu = GameObject.FindGameObjectWithTag("ScriptsMM").GetComponent<MainMenu>();
    }

    void Update()
    {
        scoreText.text = score + "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.position = new Vector2(transform.position.x, -transform.position.y);
            score += gainScore;
            if(MainMenu.muteAudio == false)
            {
                goldenSound.Play();
            }
        }
    }
}
