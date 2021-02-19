using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCoin : MonoBehaviour
{
    public float speed;
    public HitTheScreen myPlayer;
    // Update is called once per frame
    void Start()
    {
        //gameObject.GetComponent<Renderer>().material = Resources.Load<Material>("1");
        gameObject.isStatic = false;
        myPlayer = FindObjectOfType<HitTheScreen>();
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
    }
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && transform.tag=="Coin")
        {
            Destroy(gameObject);
            myPlayer.currentScore++;
        }
    }
}
