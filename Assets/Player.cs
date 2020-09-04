using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 25.0f;
    private float bound = 9;
    public Vector3 position;
    public GameObject bullet;
    public float wait = 1f;
    private float timer = 0;

   void Start(){
       position = transform.position;
   }

   void Update()
   {

       position += Vector3.right * Input.GetAxis("Horizontal") * speed;

       if(Input.GetAxis("Mouse X") != 0) {
           Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           position.x = worldPosition.x;
       }

       if (position.x < -bound) {           
           position.x = -bound;
       }
       else if (position.x > bound) {           
           position.x = bound;
       }
 
       transform.position = position;
       timer += Time.deltaTime;
       if (timer > wait && Input.GetButton("Fire1"))
       {
           timer = 0;
           Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
       }


    }

}
