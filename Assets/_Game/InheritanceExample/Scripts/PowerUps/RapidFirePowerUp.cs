using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerUp : PowerUpBase
{
    private TurretController _turret;
    private float _FireCooldownHolder;

    private void Awake()
    {
        _turret = FindObjectOfType<TurretController>();
        _FireCooldownHolder = _turret.FireCooldown;
    }

    protected override void PowerUp()
    {
        _FireCooldownHolder = _turret.FireCooldown;
        currentCD = PowerUpDuration;
        _turret.FireCooldown *= 0.5f;
    }
    protected override void PowerDown()
    {
        _turret.FireCooldown = _FireCooldownHolder;
        Destroy(gameObject);
    }

    private void Update()
    {
        if(currentCD > 0)
        {
            currentCD -= Time.deltaTime;
        }
        else if(currentCD < 0)
        {
            PowerDown();
        }
    }
}
