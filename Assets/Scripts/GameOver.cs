using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    // initializing a death panel
    public GameObject DeathPanel;

    // if the player touches a bomb, freez time and show a death panel
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bomb")
        {
            Time.timeScale = 0;

            DeathPanel.SetActive(true);
           
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
