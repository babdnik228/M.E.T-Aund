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
        _deadObstacle = 0;
        _coins = 0;
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
