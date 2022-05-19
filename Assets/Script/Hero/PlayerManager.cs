using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int _distance;
    public int _coins;
    public int _helthSideTime = 0;
    public static int _deadObstacle;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject panelUpdater;

    private void Start()
    {
        int deadObstaclePP = PlayerPrefs.GetInt("deadObstacle_player_pref");
        _deadObstacle = deadObstaclePP;
        int coinsPP = PlayerPrefs.GetInt("coins_player_pref");
        _coins = coinsPP;
    }
    private void Update()
    {
        _distance++;
        if(_helthSideTime == 78)
        {
            panelUpdater.SetActive(true);
            panel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
