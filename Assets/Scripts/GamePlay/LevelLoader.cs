using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private float speedToCreateThePlayer;

    public static int difficulty;

    public Player player1;
    public Enemy normalEnemy;
    public ExplodingEnemy explodingEnemy;


    // Start is called before the first frame update
    //void Start()
    //{
    //    player1 = new Player(speedToCreateThePlayer);
    //    normalEnemy = new Enemy();
    //    explodingEnemy = new ExplodingEnemy();

    //    normalEnemy.Attack();
    //    explodingEnemy.Attack();

    //    int results = Utilities.SumUpNumbers(2, 3);
    //    Debug.Log(results);
    //}

    // Update is called once per frame
    void Update()
    {
        //player1.Move();
    }
}
