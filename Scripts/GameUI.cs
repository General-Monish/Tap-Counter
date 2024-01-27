using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackBtnCLicked()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseBtnClicked()
    {
        gamePausePanel.SetActive(true);
    } public void MainMenuBtnClicked()
    {
        SceneManager.LoadScene(0);
    } 
    public void ResumeBtnClicked()
    {
        
    } 
    public void NextLevlBtnClicked()
    {

    } 
    public void WonBtnClicked()
    {
        gameWinPanel.SetActive(true);
    } 
    public void GameOverBtnClicked()
    {
        gameLosePanel.SetActive(true);
    }
}
