using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float PowerUpDuration;
    protected float currentCD;
    [SerializeField] private GameObject _artToDisable;
    [SerializeField] private Collider _colliderToDisable;

    protected abstract void PowerUp();
    protected abstract void PowerDown();

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Projectile>())
        {
            _artToDisable.SetActive(false);
            _colliderToDisable.enabled = false;
            PowerUp();
        }
    }
}
