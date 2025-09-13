using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life_Score : MonoBehaviour
{
    public PlayerController player;
    public Text scoreText;
    public LifeManager life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int score = updateScore();
        scoreText.text = "Score : " + score + "m";
        life.UpdateHeart(player.Life());
        if(player.Life()<=0)
        {
            enabled = false;
            Invoke("ReturnGameOver", 2.0f);
            if(PlayerPrefs.GetInt("HighScore")<score)
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }
    }

    void ReturnGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    int updateScore()
    {
        return (int)player.transform.position.z;
    }
}
