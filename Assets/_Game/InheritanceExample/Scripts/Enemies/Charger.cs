using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] private float _speedIncreaseMultiplier = 2;
    [SerializeField] private GameObject _powerUpToSpawn;
    protected override void OnHit()
    {
        //increase speed on hit
        MoveSpeed *= _speedIncreaseMultiplier;
    }

    public override void Kill()
    {
        Instantiate(_powerUpToSpawn, gameObject.transform.position, Quaternion.identity);
        base.Kill();
    }
}
