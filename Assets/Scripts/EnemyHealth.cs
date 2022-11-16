using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxhitpoints = 5;
    [SerializeField] int currentHitPoints = 0;
    Enemy enemy;

    private void OnEnable()
    {
        currentHitPoints = maxhitpoints;
        enemy = GetComponent<Enemy>();
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
            gameObject.SetActive(false);
            enemy.RewardGold();
        }
    }
}
