using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class HitTheScreen : MonoBehaviour
{
    #region Variabile
    public Vector2 lastPosition;
    public Sprite[] sprites = new Sprite[22];
    public GameObject finalDestination;
    public GameObject birdObject;
    public Camera myCamera;
    public int shape;
    public int currentScore;
    public Text scoreText;
    public Button exitButton, startButton, resume;
    public bool onGround;
    public float jumpForce, myCharacterSpeed, speed, zAxisAngle, currentOZ;
    public Rigidbody2D mySquare;
    public SpriteRenderer spriteRenderer;
    public int width,height;
    #endregion

    private void Awake()
    {
        mySquare = FindObjectOfType<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Application.targetFrameRate = 75;
        
    }
    public void Start()
    {
        if (PlayerPrefs.HasKey("SKIN"))
            mySquare.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[PlayerPrefs.GetInt("SKIN") - 1];
        zAxisAngle = 0;
        shape = 1;
        currentScore = 0;
        
        width = Screen.width;
        height = Screen.height;

        onGround = true;
        Time.timeScale = 1.0f;
    }


    
    public void Update()
    {

        scoreText.text = "Score: " + currentScore.ToString();
        
        if (mySquare.transform.position.y <= -50f) 
            Death();

        mySquare.velocity = new Vector2(myCharacterSpeed, mySquare.velocity.y);

        #region onClickAction

       

        if (mySquare.transform.position.x <= 335f && Input.GetMouseButtonDown(0) && onGround == true)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, transform.rotation.z + 90), Time.deltaTime * speed); 
            mySquare.velocity = new Vector2(mySquare.velocity.x, jumpForce);
            onGround = false;
        }
        #endregion

        if (onGround == false)
        {
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
        }
        
    }

    #region functii

    

    public void Death()
    {
        lastPosition = transform.position;
        Time.timeScale = 0;

        startButton.gameObject.transform.position = new Vector2(width / 2 + 20f, height / 2 + 200f);
        exitButton.gameObject.transform.position = new Vector2(width / 2, height / 2 - 200f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onGround = true;
        }

    }

    #endregion
}
