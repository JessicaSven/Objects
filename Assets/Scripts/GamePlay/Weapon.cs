using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Create Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private Sprite icon;
    [SerializeField] private int damage;
    [SerializeField] Bullet bulletReference;

    public void ShootMe(Vector2 position, Quaternion direction, string tag)
    {
        Bullet tempBullet = GameObject.Instantiate(bulletReference, position, direction);
        tempBullet.SetUpBullet(tag, 1);
    }
    public Weapon()
    {

    }
    public Weapon(Bullet bulletPrefab)
    {
        bulletReference = bulletPrefab;
    }
}
