using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int minutes = 1; // 초기 분
    public int seconds = 30; // 초기 초
    public Text timerText; // UI 텍스트
    public GameObject gameOver;

    private float timeRemaining;
    public bool Game;

    Sphere sps = new Sphere();


    void Start()
    {
        gameOver.SetActive(false);
        Game = true;
        // 총 시간(초)로 초기화
        timeRemaining = minutes * 60 + seconds;
    }

    void Update()
    {
        // 남은 시간이 0보다 클 때만 감소
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // 프레임 간 시간만큼 감소
        }
        else
        {
            timeRemaining = 0;
            
            Time.timeScale = 0f;
            Game = false;
            sps.Game = false;
            gameOver.SetActive(true);   
        }

        // 남은 시간을 분:초 형식으로 계산
        int displayMinutes = (int)(timeRemaining / 60);
        int displaySeconds = (int)(timeRemaining % 60);

        // UI 텍스트 업데이트
        timerText.text = $"{displayMinutes:00}:{displaySeconds:00}";

        if(Game == false)
        {
            if(Input.GetMouseButton(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1f;
            }
        }
    }
}
