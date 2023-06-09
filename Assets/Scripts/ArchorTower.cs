using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchorTower : Tower
{
    [SerializeField] Transform archor;

    protected override void Awake()
    {
        data = GameManager.Resource.Load<TowerData>("Data/ArchorTowerData");
        damage = data.Towers[0].damage;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        StartCoroutine(LookCoroutine());
        StartCoroutine(AttackCoroutine());
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        StopAllCoroutines();
    }

    public void Attack(EnemyController enemy)
    {
        enemy.TakeDamage(data.Towers[0].damage);
    }

    IEnumerator AttackCoroutine()
    {
        while (true)
        {
            if (enemyList.Count > 0)
            {
                Attack(enemyList[0]);
                Debug.Log("Attack");
                yield return new WaitForSeconds(data.Towers[0].delay);
            }
            else
            {
                yield return null;
            }
        }
    }

    IEnumerator LookCoroutine()
    {
        while (true)
        {
            if (enemyList.Count > 0)
            {
                archor.LookAt(enemyList[0].transform.position);
            }
            yield return null;
        }
    }
}
