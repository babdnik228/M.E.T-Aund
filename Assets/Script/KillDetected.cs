using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDetected : MonoBehaviour
{
    private int killed;
    private void Start()
    {
        GlobalEventManager.OnActionEnabled += EnemyKilled;
    }
    private void EnemyKilled()
    {
        killed++;
    }
}
