using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerPopper : MonoBehaviour
{
    public HitTheScreen player;
    private GameObject spikes;
    void Start()
    {
        player = FindObjectOfType<HitTheScreen>();
        spikes = GetComponent<GameObject>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + player.currentScore);
            player.Death();
        }
    }
}
