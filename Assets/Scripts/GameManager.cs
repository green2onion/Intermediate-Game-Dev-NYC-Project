using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float spawnDelay = 2;
    float spawnDelayTemp;
    public GameObject book;
    public int score = 0;
    public Text scoreText;
    public Text timeText;
    public float timeLimit = 100;
    float timeLimitTemp;
    void SpawnBook()
    {
        Instantiate(book, new Vector3(Random.Range(-9, 9), 5), new Quaternion());
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnDelayTemp = spawnDelay;
        timeLimitTemp = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: "+ score.ToString();
        timeText.text = "Time: " + timeLimitTemp.ToString("F");
        if (spawnDelayTemp > 0)
        {
            spawnDelayTemp -= Time.deltaTime;
            
        }
        else
        {
            SpawnBook();
            spawnDelayTemp = spawnDelay;
        }
        if (timeLimitTemp > 0)
        {
            timeLimitTemp -= Time.deltaTime;
        }
        else
        {
            scoreText.text = "Your final score is " + score.ToString();
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
