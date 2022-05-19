using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField]
    private GameObject _partcleCoins;
    [SerializeField]
    private GameObject _musicPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager playerManager = collision.GetComponent<PlayerManager>();
        if(playerManager != null)
        {
            GameObject coinsParticle = Instantiate(_partcleCoins, transform.position, Quaternion.identity);
            Destroy(coinsParticle, 0.6f);
            GameObject music = Instantiate(_musicPrefab, transform.position, Quaternion.identity);
            Destroy(music, 0.6f);
            playerManager._coins++;
            PlayerPrefs.SetInt("coins_player_pref", playerManager._coins);
            Destroy(gameObject);
        }
    }
}
