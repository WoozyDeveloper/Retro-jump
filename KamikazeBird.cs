using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeBird : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bird;
    HitTheScreen player;
    public Vector2 endPosition;
    public Vector2 startPosition;

    void Start()
    {
        player = FindObjectOfType<HitTheScreen>();
        endPosition = new Vector2(0f, 0f);
        startPosition = player.mySquare.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-5f, transform.position.y), 5f * Time.deltaTime);
        if (Mathf.Abs(transform.position.x - player.mySquare.transform.position.x) > 70f && Mathf.Approximately((int)player.mySquare.transform.position.x % 50, 0))
        {
            Instantiate(bird, new Vector2(player.mySquare.transform.position.x + 20f, player.mySquare.transform.position.y), Quaternion.identity);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(-5f, 2f), 5f * Time.deltaTime);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            player.Death();
    }
}
