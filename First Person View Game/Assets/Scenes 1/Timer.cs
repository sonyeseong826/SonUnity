using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int minutes = 1; // �ʱ� ��
    public int seconds = 30; // �ʱ� ��
    public Text timerText; // UI �ؽ�Ʈ
    public GameObject gameOver;

    private float timeRemaining;
    public bool Game;

    Sphere sps = new Sphere();


    void Start()
    {
        gameOver.SetActive(false);
        Game = true;
        // �� �ð�(��)�� �ʱ�ȭ
        timeRemaining = minutes * 60 + seconds;
    }

    void Update()
    {
        // ���� �ð��� 0���� Ŭ ���� ����
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // ������ �� �ð���ŭ ����
        }
        else
        {
            timeRemaining = 0;
            
            Time.timeScale = 0f;
            Game = false;
            sps.Game = false;
            gameOver.SetActive(true);   
        }

        // ���� �ð��� ��:�� �������� ���
        int displayMinutes = (int)(timeRemaining / 60);
        int displaySeconds = (int)(timeRemaining % 60);

        // UI �ؽ�Ʈ ������Ʈ
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
