using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttackRange : MonoBehaviour
{
    public UnityAction<EnemyController> OnEnter;
    public UnityAction<EnemyController> OnExit;

    public LayerMask enemyMask;

    private void OnTriggerEnter(Collider other)
    {
        if (enemyMask.IsContain(other.gameObject.layer))
        {
            //Debug.Log("적 들어옴");
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            OnEnter?.Invoke(enemy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (enemyMask.IsContain(other.gameObject.layer))
        {
            //Debug.Log("적 나감");
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            OnExit?.Invoke(enemy);
        }
    }
}
