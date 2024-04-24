using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int damage;
    public float bulletSpeed;
    private string targetTag;

    SpriteRenderer spriteRenderer;
    public Sprite[] allPaints;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    public void SetUpBullet(string tag, int damageParam)
    {
        damage = damageParam;
        targetTag = tag;
    }
    private void Update()
    {
        //JUST MOVING FORWARD
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        spriteRenderer.sprite = allPaints[Random.Range(0, allPaints.Length)];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            //DO DAMAGE TO ENEMY
            collision.GetComponent<IDamagable>().ReceiveDamage(damage);
            Destroy(gameObject);
        }
    }


    //public void Move()
    //{

    //}
    //public void Explode()
    //{

    //}
    //public Bullet(int newDamage, int bulletSpeed)
    //{

    //}
}
