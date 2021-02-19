using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class OnPlayEvent : MonoBehaviour
{
    private const int lvlmax = 31;
    void Start()
    {
        //Advertisement.Initialize("123BLABLABLA", true);
        Advertisement.Initialize("3787799", true);
    }

    public void ClickExtraGems()
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            if(Advertisement.isShowing)
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 10);
        }
    }

    public void ClickOnPlay()
    {
        if (PlayerPrefs.HasKey("LoadLevel") && PlayerPrefs.GetInt("LoadLevel") <= lvlmax)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("LoadLevel"));
        }
        else if (PlayerPrefs.HasKey("LoadLevel"))
            SceneManager.LoadScene(PlayerPrefs.GetInt("LoadLevel"));
        else
            SceneManager.LoadScene(2);//daca nu exista valoare sa inceapa lvl 1
        
    }

    #region Death Buttons
   
    public void onStartHereButton()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            HitTheScreen rigidbody = FindObjectOfType<HitTheScreen>();
            Debug.Log("WTF");
            rigidbody.resume.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            rigidbody.transform.position = new Vector2(rigidbody.lastPosition.x - 5f, rigidbody.lastPosition.y + 3f);

            rigidbody.exitButton.transform.position = new Vector3(-200, -200, -200);
            rigidbody.startButton.transform.position = new Vector3(-200, -200, -200);
        }
    }
    public void ClickOnResume()
    {
        HitTheScreen rigidbody = FindObjectOfType<HitTheScreen>();
        rigidbody.resume.transform.position = new Vector3(-200f, -200f, -200f);

        Time.timeScale = 1;
    }
    public void onRetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    
    #endregion


    public void ClickExit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
    public void ClickOnHome()
    {
        SceneManager.LoadScene(1);
    }

    public void ClickBackFromHome()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ClickOnShop()
    {
        SceneManager.LoadScene(2);
     
    }
}
