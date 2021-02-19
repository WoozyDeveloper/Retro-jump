using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GenerateLevel : MonoBehaviour
{
    private int currentLevel = 0, difficulty = 0, positionOX = 0;
    private int[] width = new int[5];
    private const int size = 5, platformWidth = 40;// how many platforms to choose from - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public GameObject[] platforms = new GameObject[size], finishLine;
    private Text lvlText = null;

    // Start is called before the first frame update
    private void Awake()
    {
        width[0] = 90;
        width[1] = 270;
        width[2] = 90;
        width[3] = 184;
        width[4] = 184;
        positionOX = 60;
        if (currentLevel <= 30) difficulty = 1;
        else if (currentLevel > 30 && currentLevel <= 40) difficulty = 2;
        else difficulty = 3;
    }
    short generateNumber(short left,short right)
    {
        --right;
        --left;
        return (short)Random.Range(left + .0f, right + .0f);
    }
    void Start()
    {
        int num = 0;
        //TODO vezi ca nu se pupa platformele bn mereu
        switch(difficulty)
        {
            case 1:
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(60 , 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                break;
            case 2:
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                break;
            default:
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                num = generateNumber(1, 5);
                Instantiate(platforms[num], new Vector2(positionOX += width[num], 0f), Quaternion.Euler(0f, 0f, 0f));
                break;
        }
        currentLevel = PlayerPrefs.GetInt("LoadLevel");
        lvlText = GetComponent<Text>();
    }
}
