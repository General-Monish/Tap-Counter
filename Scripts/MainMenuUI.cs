using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    [SerializeField] private GameObject howToPlay;
    [SerializeField] private GameObject credits;
    [SerializeField] private GameObject mainMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
        howToPlay.SetActive(false);
        credits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingBtnClicked()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }
    public void HotToPlayBtnClicked()
    {
        mainMenu.SetActive(false);
        howToPlay.SetActive(true);   
    }
    public void CreditsBtnClicked()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    } 

    public void BackBtnClicked()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
        howToPlay.SetActive(false);
        credits.SetActive(false);
    }

    public void PlayBtnClicked()
    {
        SceneManager.LoadScene("Game");
    }
}
