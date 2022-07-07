using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    
    public Text scoreGT;
    GameObject scoreGO;
    void Start()
    {
        scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Platform")
        {
            int score = int.Parse(scoreGT.text);
            score += 1;
            scoreGT.text = score.ToString();
            if (score == 100) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
        }
        
    }
}
