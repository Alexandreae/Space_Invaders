using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    public GameObject aliens;
    public GameObject player;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if( player == null)
            SceneManager.LoadScene("GameOver");
        else if(aliens.transform.childCount == 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
