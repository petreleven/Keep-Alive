using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public Vector2 secondsBetweenSpawnMinMax;
    float nextSpawnTime;
    Vector2 screenSize;
    void Start()
    {
       screenSize=new Vector2(Camera.main.aspect * Camera.main.orthographicSize,Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextSpawnTime)
        {
            float secondsBetweenSpawn=Mathf.Lerp(secondsBetweenSpawnMinMax.y,secondsBetweenSpawnMinMax.x,Difficulty.GetDifficultyPercent());
            nextSpawnTime=Time.time +  secondsBetweenSpawn;
            Vector2 position=new Vector2(Random.Range(-screenSize.x,screenSize.x),screenSize.y + obstacle.transform.localScale.y/2f);
            Vector3 size=new Vector3(Random.Range(0.5f,2.5f),1f,0f);
            Vector3 Rotation=new Vector3(0,0,1) * Random.Range(-20f,20f);
            obstacle.transform.localScale = size;
            Instantiate(obstacle,position,Quaternion.Euler(Rotation));
            
        }
        
    }

}
