using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOver;
    public Text secondsSurvived;
    float sec;
    bool gameisOver;

    void Start()
    {
        FindObjectOfType <Player>().OnPlayerDeath +=OnGameOver;
    }
    void Update()
    {
        if (gameisOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
                
            }
        }
    }

    public void OnGameOver()
    {
        gameOver.SetActive(true);
        sec=Time.timeSinceLevelLoad;
        secondsSurvived.text=Mathf.RoundToInt(sec).ToString();
        gameisOver=true;
    }
}

