using UnityEngine;

public class Helth : MonoBehaviour
{
    [SerializeField]
    private GameObject _partcleHelth;
    [SerializeField]
    private GameObject _musicPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            GameObject coinsParticle = Instantiate(_partcleHelth, transform.position, Quaternion.identity);
            Destroy(coinsParticle, 0.6f);
            GameObject music = Instantiate(_musicPrefab, transform.position, Quaternion.identity);
            Destroy(music, 0.6f);
            player._health++;
            Destroy(gameObject);
        }
    }
}
