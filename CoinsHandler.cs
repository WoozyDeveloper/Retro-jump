using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    public Text coinText;
    // Start is called before the first frame update
    void Update()
    {
        coinText = GetComponent<Text>();
        coinText.text = PlayerPrefs.GetInt("Coins").ToString();
    }

}
