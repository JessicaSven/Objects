using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public string enemyName;

    [SerializeField] private float time;
    [SerializeField] private float attackDistance;
    private Player target;

    SpriteRenderer spriteRenderer;
    public Sprite[] allEnemies;

    protected override void Start()
    {
        base.Start();
    }

    public void SetUpEnemy(int healthParam)
    {
        healthPoints = new Health(healthParam);
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);

    }
    public void ChangedHealth(int health)
    {
        Debug.Log("LIFE HAS CHANGED" + health);
        if (health <= 0)
        {
            //increase score
            GameManager.singleton.scoreManager.IncreaseScore();
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if(target != null)
        {
            Vector2 direction = target.transform.position - transform.position;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Move(direction, angle - 90f);
        }
        
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = allEnemies[Random.Range(0, allEnemies.Length)];
    }

    public Enemy(string enemyName)
    {
        //this.enemyName = enemyName;
    }

    public override void Attack()
    {
        target.ReceiveDamage();
    }
    public override void Die()
    {
        GameManager.singleton.EndGame();
        Destroy(gameObject);
    }
    public override void Move(Vector2 direction, float angle)
    {
        if(Vector2.Distance(target.transform.position, transform.position) > attackDistance)
        {
            base.Move(direction, angle);
        }
       
        else //everytime the enmy is close to the player
        {
            //    //STOP IMMEDIATELY UPON CONTACT WITH PLAYER
            //    rigidBody.velocity = Vector2.zero;
            time += Time.deltaTime;

            if(time >= 3f)
            {
                Attack();
                time = 0;
                Debug.Log("I attack player");
            }
            
        }


    }

}
