using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour 
{
    public int TEST;
    public int coins; string key;
    public Text[] text = new Text[21];

    void Start()
    {
        key = null;
        for(int i=1;i<=21;++i)
        {
            key = "b";
            key = key.Insert(1, i.ToString());
            if (PlayerPrefs.HasKey(key))
                text[i - 1].text = "OWNED!";
            if (PlayerPrefs.GetInt("SKIN") == i)
                text[i - 1].text = "!SELECTED!";
        }
    }

    private void Update()
    {
        TEST = PlayerPrefs.GetInt("SKIN") - 1;
        coins = PlayerPrefs.GetInt("Coins");
    }

    public void b1()
    {
        if (!PlayerPrefs.HasKey("b1"))
        {
            if (coins >= 10)
            {
                PlayerPrefs.SetInt("b1", 1);
                coins -= 10;
                text[0].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 1);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 1);
            text[0].text = "!SELECTED!";
        }
    }

    public void b2()
    {
        if (!PlayerPrefs.HasKey("b2"))
        {
            if (coins >= 10)
            {
                PlayerPrefs.SetInt("b2", 1);
                coins -= 10;
                text[1].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 2);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 2);
            text[1].text = "!SELECTED!";
        }
    }
    public void b3()
    {
        if (!PlayerPrefs.HasKey("b3"))
        {
            if (coins >= 10)
            {
                PlayerPrefs.SetInt("b3", 1);
                coins -= 10;
                text[2].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 3);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 3);
            text[2].text = "!SELECTED!";
        }
    }
    public void b4()
    {
        if (!PlayerPrefs.HasKey("b4"))
        {
            if (coins >= 10)
            {
                PlayerPrefs.SetInt("b4", 1);
                coins -= 10;
                text[3].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 4);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 4);
            text[3].text = "!SELECTED!";
        }
    }
    public void b5()
    {
        if (!PlayerPrefs.HasKey("b5"))
        {
            if (coins >= 20)
            {
                PlayerPrefs.SetInt("b5", 1);
                coins -= 20;
                text[4].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 5);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 5);
            text[4].text = "!SELECTED!";
        }
    }
    public void b6()
    {
        if (!PlayerPrefs.HasKey("b6"))
        {
            if (coins >= 20)
            {
                PlayerPrefs.SetInt("b6", 1);
                coins -= 20;
                text[5].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 6);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 6);
            text[5].text = "!SELECTED!";
        }
    }
    public void b7()
    {
        if (!PlayerPrefs.HasKey("b7"))
        {
            if (coins >= 20)
            {
                PlayerPrefs.SetInt("b7", 1);
                coins -= 20;
                text[6].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 7);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 7);
            text[6].text = "!SELECTED!";
        }
    }
    public void b8()
    {
        if (!PlayerPrefs.HasKey("b8"))
        {
            if (coins >= 50)
            {
                PlayerPrefs.SetInt("b8", 1);
                coins -= 50;
                text[7].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 8);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 8);
            text[7].text = "!SELECTED!";
        }
    }
    public void b9()
    {
        if (!PlayerPrefs.HasKey("b9"))
        {
            if (coins >= 50)
            {
                PlayerPrefs.SetInt("b9", 1);
                coins -= 50;
                text[8].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 9);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 9);
            text[8].text = "!SELECTED!";
        }
    }
    public void b10()
    {
        if (!PlayerPrefs.HasKey("b10"))
        {
            if (coins >= 50)
            {
                PlayerPrefs.SetInt("b10", 1);
                coins -= 50;
                text[9].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 10);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 10);
            text[9].text = "!SELECTED!";
        }
    }
    public void b11()
    {
        if (!PlayerPrefs.HasKey("b11"))
        {
            if (coins >= 50)
            {
                PlayerPrefs.SetInt("b11", 1);
                coins -= 50;
                text[10].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 11);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 11);
            text[10].text = "!SELECTED!";
        }
    }
    public void b12()
    {
        if (!PlayerPrefs.HasKey("b12"))
        {
            if (coins >= 60)
            {
                PlayerPrefs.SetInt("b12", 1);
                coins -= 60;
                text[11].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 12);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 12);
            text[11].text = "!SELECTED!";
        }
    }
    public void b13()
    {
        if (!PlayerPrefs.HasKey("b13"))
        {
            if (coins >= 60)
            {
                PlayerPrefs.SetInt("b13", 1);
                coins -= 60;
                text[12].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 13);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 13);
            text[12].text = "!SELECTED!";
        }
    }
    public void b14()
    {
        if (!PlayerPrefs.HasKey("b14"))
        {
            if (coins >= 60)
            {
                PlayerPrefs.SetInt("b14", 1);
                coins -= 60;
                text[13].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 14);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 14);
            text[13].text = "!SELECTED!";
        }
    }
    public void b15()
    {
        if (!PlayerPrefs.HasKey("b15"))
        {
            if (coins >= 70)
            {
                PlayerPrefs.SetInt("b15", 1);
                coins -= 70;
                text[14].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 15);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 15);
            text[14].text = "!SELECTED!";
        }
    }
    public void b16()
    {
        if (!PlayerPrefs.HasKey("b16"))
        {
            if (coins >= 70)
            {
                PlayerPrefs.SetInt("b16", 1);
                coins -= 70;
                text[15].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 16);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 16);
            text[15].text = "!SELECTED!";
        }
    }

    public void b17()
    {
        if (!PlayerPrefs.HasKey("b17"))
        {
            if (coins >= 100)
            {
                PlayerPrefs.SetInt("b17", 1);
                coins -= 100;
                text[16].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 17);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 17);
            text[16].text = "!SELECTED!";
        }
    }
    public void b18()
    {
        if (!PlayerPrefs.HasKey("b18"))
        {
            if (coins >= 100)
            {
                PlayerPrefs.SetInt("b18", 1);
                coins -= 100;
                text[17].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 18);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 18);
            text[17].text = "!SELECTED!";
        }
    }
    public void b19()
    {
        if (!PlayerPrefs.HasKey("b19"))
        {
            if (coins >= 100)
            {
                PlayerPrefs.SetInt("b19", 1);
                coins -= 100;
                text[18].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 19);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 19);
            text[18].text = "!SELECTED!";
        }
    }
    public void b20()
    {
        if (!PlayerPrefs.HasKey("b20"))
        {
            if (coins >= 500)
            {
                PlayerPrefs.SetInt("b20", 1);
                coins -= 500;
                text[19].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 20);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 20);
            text[19].text = "!SELECTED!";
        }
    }
    public void b21()
    {
        if (!PlayerPrefs.HasKey("b21"))
        {
            if (coins >= 1000)
            {
                PlayerPrefs.SetInt("b21", 1);
                coins -= 1000;
                text[20].text = "OWNED!";
                PlayerPrefs.SetInt("SKIN", 21);
                PlayerPrefs.SetInt("Coins", coins);
            }
        }
        else
        {
            for (int i = 1; i <= 21; ++i)
            {
                key = "b";
                key = key.Insert(1, i.ToString());
                if (PlayerPrefs.HasKey(key))
                    text[i - 1].text = "OWNED!";

            }
            PlayerPrefs.SetInt("SKIN", 21);
            text[20].text = "!SELECTED!";
        }
    }
}
