using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour, IHittable
{
    protected int curHp = 3;
    public int CurHp { get { return curHp; } private set { curHp = value; OnChangedHp?.Invoke(curHp); } }
    public UnityAction<int> OnChangedHp;

    public void TakeDamage(int damage)
    {
        curHp -= damage;
        Debug.Log("Hitted");
    }
}
