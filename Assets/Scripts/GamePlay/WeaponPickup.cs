using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : PickUp
{
    [SerializeField] private Weapon newWeapon;
    protected override void PickMe(Character characterToChange)
    {
        //SEND "newWeapon" to the player
        base.PickMe(characterToChange);
    }
}
