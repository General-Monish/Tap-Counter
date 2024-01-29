using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    [SerializeField] private GameObject settingsBtn;
    [SerializeField] private GameObject howToPlay;
    [SerializeField] private GameObject credits;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject fadePanel;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource aD;
    [SerializeField] private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        Fadein();
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
        SoundUI();
        mainMenu.SetActive(false);
        settings.SetActive(true);
        settingsBtn.SetActive(false);
        anim.SetTrigger("in");
    }
    public void HotToPlayBtnClicked()
    {
        SoundUI();
        mainMenu.SetActive(false);
        howToPlay.SetActive(true);   
    }
    public void CreditsBtnClicked()
    {
        SoundUI();
        mainMenu.SetActive(false);
        credits.SetActive(true);
    } 

    public void BackBtnClicked()
    {
        SoundUI();
        anim.SetTrigger("out");
        StartCoroutine(DisableSettingsPanel());
        // settings.SetActive(false);
        mainMenu.SetActive(true);
        howToPlay.SetActive(false);
        credits.SetActive(false);
    }

    public void PlayBtnClicked()
    {
        Fadeout();
        SoundUI();
        StartCoroutine(DelayLevel());
      
    }

    IEnumerator DelayLevel()
    {
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("Game");
    }

    private void SoundUI()
    {
        aD.PlayOneShot(audioClip);
    }

    public IEnumerator DisableSettingsPanel()
    {
        yield return new WaitForSeconds(1);
        settings.SetActive(false);
        settingsBtn.SetActive(true);
    }

    void Fadein()
    {
        fadePanel.GetComponent<Animator>().SetTrigger("fin");
    }
    void Fadeout()
    {
        fadePanel.GetComponent<Animator>().SetTrigger("fout");
    }
}
