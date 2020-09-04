using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alien : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Base" || collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
    void update ()
    {
        if (transform.position.y < -5) {           
           SceneManager.LoadScene("GameOver");
       }
    }
}
