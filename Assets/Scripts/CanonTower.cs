using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonTower : Tower
{
    protected override void Awake()
    {
        data = GameManager.Resource.Load<TowerData>("Data/CanonTowerData");
    }
}
