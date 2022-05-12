using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updater : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private PlayerManager playerManager;
   public void UpdateHealth()
    {
        if(PlayerManager._deadObstacle > 5)
        {
            player._health++;
        }
    }
    public void UpdateTimeShotInterval()
    {
        if(playerManager._coins > 2)
        {
            player._timerShotInterv--;
        }
    }
}
