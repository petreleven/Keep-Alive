using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event System.Action OnPlayerDeath;
    Rigidbody myRigidbody;
    public float speed=7;
    float screenWidth;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody=GetComponent <Rigidbody> ();
        float playerWidth = transform.localScale.x/2f;
        screenWidth = Camera.main.aspect * Camera.main.orthographicSize + playerWidth;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX=Input.GetAxisRaw("Horizontal");
        float velocity = inputX * speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        if (transform.position.x > screenWidth)
        {
            transform.position = new Vector2(-screenWidth ,transform.position.y);
        }
        if(transform.position.x < -screenWidth )
        { 
            transform.position = new Vector2 (screenWidth ,transform.position.y);
        }
    }

    
    void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.tag=="Falling Block")
        {
            if (OnPlayerDeath != null)
            {
                OnPlayerDeath();
            }
            Destroy(this.gameObject);
        }
    }
}
