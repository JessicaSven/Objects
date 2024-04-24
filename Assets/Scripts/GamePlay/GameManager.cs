using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public ScoreManager scoreManager;
    Coroutine c;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Enemy enemyPrefab;
    private float timer;

    private void Awake()
    {
        singleton = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartSpawningEnemy();
        //StopCoroutine(c);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void EndGame()
    {
        StopAllCoroutines();
        scoreManager.RegisterHighScore();
    }
    
    public void StartSpawningEnemy()
    {
        c = StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        {

            yield return new WaitForSeconds(1f);
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Enemy enemy = Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            enemy.SetUpEnemy(1);
        }
    }


}
