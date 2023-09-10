using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int cost = 75;
    
    public bool CreateTower(Tower tower, Vector3 position)
    {
        Bank bankOfTheRealm = FindObjectOfType<Bank>();

        if (bankOfTheRealm == null)
        {
            return false;
        }

        if (bankOfTheRealm.CurrentBalance >= cost)
        {
            Instantiate(tower.gameObject, position, Quaternion.identity);
            bankOfTheRealm.Withdraw(cost);
            return true;
        }

        return false;
    }
    
}
