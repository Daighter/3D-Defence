using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    [SerializeField] protected TowerData data;

    public List<EnemyController> enemyList;

    protected virtual void Awake()
    {
        enemyList = new List<EnemyController>();
    }

    protected virtual void OnEnable()
    {
        GetComponent<AttackRange>().OnEnter += AddEnemy;
        GetComponent<AttackRange>().OnExit += RemoveEnemy;
    }

    protected virtual void OnDisable()
    {
        GetComponent<AttackRange>().OnEnter -= AddEnemy;
        GetComponent<AttackRange>().OnExit -= RemoveEnemy;
    }

    private void AddEnemy(EnemyController enemy)
    {
        //Debug.Log("적 추가");
        enemyList.Add(enemy);
    }

    private void RemoveEnemy(EnemyController enemy)
    {
        //Debug.Log("적 제거");
        enemyList.Remove(enemy);
    }

    protected int damage;
    public int Damage { get { return damage; } }
}
