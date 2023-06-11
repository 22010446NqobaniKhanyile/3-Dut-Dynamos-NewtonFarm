using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Square").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
         Destroy(gameObject,3.0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.AddScore();
            player.FinalHighScore();

            Destroy(gameObject);

        }
    }

}
