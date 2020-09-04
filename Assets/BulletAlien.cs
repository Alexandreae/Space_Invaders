using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAlien : MonoBehaviour
{

    public float speed = 5.0f;
    public GameObject boomAlien;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Base")
        {
            Instantiate(boomAlien, gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }   
}


