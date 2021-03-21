using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Vector2 direction; // unit vector
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction * speed;
        this.gameObject.GetComponent<Transform>().position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
       if(collision.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(collision.gameObject);
            GameObject.Destroy(this.gameObject);
        }
    }
}
