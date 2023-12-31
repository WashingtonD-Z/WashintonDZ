using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IDamageable))]
public class SpawnParticleSystemOnDeath : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem DeathSystem;
    public IDamageable damageable;
    
    private void Awake()
    {
        damageable = GetComponent<IDamageable>();
    }
    private void OnEnable() 
    {
        damageable.OnDeath += damageable_OnDeath;
    }

    private void damageable_OnDeath(Vector3 Position)
    {
        Instantiate(DeathSystem, Position, Quaternion.identity);
    }
}
