using UnityEngine;

public class Obstacle : MonoBehaviour
{
    
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private GameObject _particDeadObstacle;
    [SerializeField]
    private GameObject _musPrefab;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if(player != null)
        {
            GameObject particlDead = Instantiate(_particDeadObstacle, transform.position, Quaternion.identity);
            Destroy(particlDead, 0.6f);
            GameObject musPrefab = Instantiate(_musPrefab, transform.position, Quaternion.identity);
            Destroy(musPrefab, 0.6f);
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

}
