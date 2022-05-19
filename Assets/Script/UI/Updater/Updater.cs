using UnityEngine;

public class Updater : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private PlayerManager playerManager;
   public void UpdateHealth()
    {
        if(PlayerManager._deadObstacle >= 5)
        {
            player._health++;
            PlayerPrefs.SetInt("Player_Health", player._health);
            PlayerManager._deadObstacle -= 5;
            PlayerPrefs.SetInt("deadObstacle_player_pref", PlayerManager._deadObstacle);
        }
    }
    public void UpdateTimeShotInterval()
    {
        if(playerManager._coins >= 2)
        {
            player._timerShotInterv--;
            playerManager._coins -= 2;
        }
    }
}
