using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    private const int lastIndex = 31;//valoarea pt ultima scena
    public bool test;
    // Start is called before the first frame update
    void Start()
    {
        test = false;
    }

    void Update()
    {
        if (test == true)//test daca am ajuns
        { 
            PlayerPrefs.SetInt("LoadLevel",SceneManager.GetActiveScene().buildIndex + 1);
            if (SceneManager.GetActiveScene().buildIndex == lastIndex)
            {
                SceneManager.LoadScene(3);//scena 1
                PlayerPrefs.SetInt("LoadLevel",3);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            test = true;
    }

}
