using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldReward = 25;
    [SerializeField] int goldPenalty = 25;

    Bank bankOfTheRealm;
    
    void Start()
    {
        bankOfTheRealm = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        if(bankOfTheRealm == null) { return; }
        bankOfTheRealm.Deposit(goldReward);
    }

    public void StealGold()
    {
        if(bankOfTheRealm == null) { return; }
        bankOfTheRealm.Withdraw(goldPenalty);
    }
}
