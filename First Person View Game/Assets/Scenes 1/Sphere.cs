using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public Vector3 Max = new Vector3(3.5f, 0.7f, 7.5f);
    public Vector3 Min = new Vector3(-3.5f, 5.3f, 7.5f);

    public int score = 0;
    public Text scoreText;
    public Text BestScore;

    public bool Game = true;

    void OnMouseDown()
    {
        if (Game == true)
        {
            float RandomX = Random.Range(Max.x, Min.x);
            float RandomY = Random.Range(Max.y, Min.y);

            transform.position = new Vector3(RandomX, RandomY, 7.5f);

            score += 1;
            scoreText.text = "Score : " + score;
            BestScore.text = "My-Score : " + score;

        }
    }
}
