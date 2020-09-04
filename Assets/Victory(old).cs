using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{

    public GameObject aliens;
    public GameObject player;
    
    void start()
    {
        gameObject.GetComponent<Text>().text = "";
    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = "";
        if( player == null)
            gameObject.GetComponent<Text>().text = "Vitória dos Aliens";
        else if(aliens.transform.childCount == 0)
        {
            gameObject.GetComponent<Text>().text = "Vitória do Jogador";
        }
    }
}
