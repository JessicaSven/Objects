using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour, IDamagable
{
    [SerializeField] public float speed;
    private int strength;
    protected Health healthPoints;
    
    [SerializeField] protected Rigidbody2D rigidBody;

    protected virtual void Start()
    {
        healthPoints = new Health(5);
    }

    public abstract void Attack(); //a virtual method means that it can be overridden by children classes

    public abstract void Die();

    public Health();
    

    public virtual void Move(Vector2 direction, float angle)
    {
        
        rigidBody.AddForce(direction.normalized * speed * Time.deltaTime * 500f);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void ReceiveDamage()
    {
        healthPoints.DecreaseLife();
    }

    public void ReceiveDamage(int damage)
    {
        healthPoints.DecreaseLife(damage);
    }
    //public Character()
    //{
    //    speed = 5f;
    //}
    //public Character(float speed, int health)
    //{
    //    this.speed = speed;
    //    healthPoints = new Health(health);
    //}
}
