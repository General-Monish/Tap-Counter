using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject pauseBtn;
    [SerializeField] private GameObject gameWinPanel;
    [SerializeField] private GameObject gameLosePanel;
    [SerializeField] private GameObject gamePausePanel;
    [SerializeField] private GameObject resume;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject nextLevel;
    [SerializeField] private GameObject gameWinBtn;
    [SerializeField] private GameObject gameOverBtn;
    [SerializeField] private gameManager gameManager;
    [SerializeField] private TextMeshProUGUI tapCountText;
    [SerializeField] private TextMeshProUGUI TimerText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI ResetHighscoreText;
    [SerializeField] private TextMeshProUGUI CountDownText;
    public bool isPaused;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Update()
    {
        TimerText.text = "Timer :" + gameManager.timer.ToString("N0");
        if (!gameManager.CountDownTimerEnded)
        {
            CountDownText.text = gameManager.countDown.ToString("N0");
        }
       
    }

    public void DisableCountDownTimer()
    {
        CountDownText.gameObject.SetActive(false);
    }

    public void BackBtnCLicked()
    {
        SceneManager.LoadScene(0);
    }
    public void MainMenuBtnCLicked()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartBtnCLicked()
    {
        SceneManager.LoadScene(1);
    }
    public void UpdatingTapCount()
    {
        tapCountText.text = gameManager.tapCount.ToString();
    }

    public void HighScoreUI()
    {
        highScoreText.text ="highScore :" + gameManager.highScore.ToString();
    }  

    public void WinLoseScreen()
    {
        if (gameManager.hasWon)
        {
            gameWinPanel.SetActive(true);
        }
        else
        {
            gameLosePanel.SetActive(true);
        }
    }

    public void ResetHighScoreBtnClicked()
    {
        gameManager.ResetHighScore();
        gameManager.HighscoreUpdate();
        Debug.Log("Reset Clicked");
    }

    public void PauseResumeBtnClicked()
    {
        if (Time.timeScale == 0)
        {
            // Currently paused, so resume
            Time.timeScale = 1;
            isPaused = false;
            gamePausePanel.SetActive(false);
        }
        else
        {
            // Currently not paused, so pause
            Time.timeScale = 0;
            isPaused = true;
            gamePausePanel.SetActive(true);
        }
    }



}
