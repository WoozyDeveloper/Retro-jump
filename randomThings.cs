using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomThings : MonoBehaviour
{
    private float task = 1;
    public HitTheScreen myPlayer;
    private GameObject changer;
    public Sprite sprite1, sprite2;
    public PolygonCollider2D colliderSquare;
    // Start is called before the first frame update
    void Start()
    {
        changer = GetComponent<GameObject>();
        myPlayer = FindObjectOfType<HitTheScreen>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            task = UnityEngine.Random.Range(1, 4);
            switch(task)
            {
                case 1:
                    if (myPlayer.transform.localScale.x < 2f && myPlayer.transform.localScale.y < 2f)
                        changePlayer();
                    else
                        resetSize();
                    break;
                case 2:
                    extraJump();
                    break;
                case 3:
                    changeSize();
                    break;

            }
        }
    }

    public void changePlayer()
    {
        if(PlayerPrefs.HasKey("SKIN"))
            switch (myPlayer.shape)
            {
                //cerc
                case 1:
                    //Destroy(myPlayer.GetComponent<PolygonCollider2D>());
                    //myPlayer.mySquare.gameObject.AddComponent<PolygonCollider2D>();
                    myPlayer.mySquare.gameObject.GetComponent<SpriteRenderer>().sprite = myPlayer.sprites[PlayerPrefs.GetInt("SKIN") - 1];
                    myPlayer.shape=2;
                    myPlayer.spriteRenderer = GetComponent<SpriteRenderer>();
                    break;

                //patrat
                case 2:
                    //Destroy(myPlayer.GetComponent<PolygonCollider2D>());
                    //myPlayer.mySquare.gameObject.AddComponent<PolygonCollider2D>();
                    myPlayer.mySquare.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>((PlayerPrefs.GetInt("SKIN")+1).ToString());
                    myPlayer.shape=1;
                    myPlayer.spriteRenderer = GetComponent<SpriteRenderer>();
                    break;
            }
        else
        {
            switch (myPlayer.shape)
            {
                //cerc
                case 1:
                    myPlayer.mySquare.gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
                    myPlayer.shape = 2;
                    myPlayer.spriteRenderer = GetComponent<SpriteRenderer>();
                    break;

                //patrat
                case 2:
                    myPlayer.mySquare.gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
                    myPlayer.shape = 1;
                    myPlayer.spriteRenderer = GetComponent<SpriteRenderer>();
                    break;
            }
        }
        
    }

    private void extraJump()
    {
        myPlayer.mySquare.transform.Rotate(0f, 0f, myPlayer.speed * Time.deltaTime);
        myPlayer.mySquare.velocity = new Vector2(0f, myPlayer.jumpForce);
    }
    
    private void resetSize()
    {
        myPlayer.myCamera.transform.position = new Vector3(myPlayer.myCamera.transform.position.x, myPlayer.myCamera.transform.position.y, -13f);
        if (myPlayer.mySquare.gameObject.GetComponent<SpriteRenderer>().sprite == sprite1)
            myPlayer.mySquare.transform.localScale -= new Vector3(myPlayer.mySquare.transform.localScale.x - 1.3f, myPlayer.mySquare.transform.localScale.y - 1.3f);
        else
            myPlayer.mySquare.transform.localScale -= new Vector3(myPlayer.mySquare.transform.localScale.x - 1f, myPlayer.mySquare.transform.localScale.y - 1f);
        myPlayer.spriteRenderer = GetComponent<SpriteRenderer>();
        myPlayer.spriteRenderer.sprite = myPlayer.sprites[20];
    }

    private void changeSize()
    {
        if (myPlayer.transform.localScale.x == myPlayer.transform.localScale.y)
        {
            myPlayer.myCamera.transform.position = new Vector3(myPlayer.myCamera.transform.position.x, myPlayer.myCamera.transform.position.y, -18f);
            float oxScale = UnityEngine.Random.Range(0.3f, 0.6f), oyScale = UnityEngine.Random.Range(0.3f, 0.6f);
            myPlayer.mySquare.transform.localScale += new Vector3(oxScale, oyScale);
            myPlayer.mySquare.position = Vector3.MoveTowards(transform.position, new Vector3(myPlayer.transform.position.x, myPlayer.transform.position.y, -19f), Time.deltaTime * 2f);
            myPlayer.spriteRenderer = GetComponent<SpriteRenderer>();
            myPlayer.spriteRenderer.sprite = myPlayer.sprites[20];
        }
        else
            resetSize();
    }
}
