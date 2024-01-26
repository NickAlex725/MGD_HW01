using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] private float _speedIncreaseMultiplier = 2;
    protected override void OnHit()
    {
        //increase speed on hit
        MoveSpeed *= _speedIncreaseMultiplier;
    }
}
