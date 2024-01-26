using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    [SerializeField] private float _onHitPauseTime = 1;
    private float _moveSpeedHolder;
    private float _currentCD;
    protected override void OnHit()
    {
        _currentCD = _onHitPauseTime;
    }

    private void Start()
    {
        _moveSpeedHolder = MoveSpeed;
    }

    private void Update()
    {
        if(_currentCD > 0)
        {
            MoveSpeed = 0;
            _currentCD -= Time.deltaTime;
        }
        else if (_currentCD <= 0)
        {
            MoveSpeed = _moveSpeedHolder;
        }
    }
}
