using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour
{
    private HitTheScreen player;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        player = FindObjectOfType<HitTheScreen>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -13f);
    }
}
