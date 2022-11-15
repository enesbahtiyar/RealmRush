using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocater : MonoBehaviour
{
    Transform enemy;
    [SerializeField] Transform weapon;

    void Start()
    {
        enemy = FindObjectOfType<EnemyMover>().transform;
    }

    void Update()
    {
        AimWeapon();
    }

    private void AimWeapon()
    {
        weapon.LookAt(enemy);
    }
}
