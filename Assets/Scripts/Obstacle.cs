using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector2 speedminmax;
    float speed;
    float maxLifeDist;
    void Start()
    {
        speed=Mathf.Lerp(speedminmax.x,speedminmax.y,Difficulty.GetDifficultyPercent());
        maxLifeDist=-(Camera.main.orthographicSize + transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < maxLifeDist)
        {
            Destroy(this.gameObject);
        }
    }
}
