using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxhitpoints = 5;
    [SerializeField] int currentHitPoints = 0;

    private void Awake()
    {
        currentHitPoints = maxhitpoints;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHitPoints--;

        if (currentHitPoints < 1)
        {
            Destroy(this.gameObject);
        }
    }
}