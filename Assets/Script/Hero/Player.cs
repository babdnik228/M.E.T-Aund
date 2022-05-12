using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Transform _pointShot;
    [SerializeField]
    private GameObject _bulletPrefab;
    
    public float _timerShotInterv = 5;
    [SerializeField]
    private float _shotTimer;
    [SerializeField]
    private GameObject _particlShot;
    [SerializeField]
    private GameObject _laserVolume;
    [SerializeField]
    private GameObject[] _object;
    [SerializeField]
    private GameObject _protectionCircle;
    public int _health;
    [SerializeField]
    private GameObject _panel;
    [SerializeField] private GameObject panelUpdater;

    private void Update()
    {
        Move();
        Shoot();
        if(_health <= 0)
        {
            for (int i = 0; i < _object.Length; i++)
            {
                Destroy(_object[i]);
            }
            panelUpdater.SetActive(true);
            _panel.SetActive(true);
            Destroy(gameObject);
        }
    }
    void Move()
    {
        Vector3 mousPos = Input.mousePosition;
        Vector3 realPos = Camera.main.ScreenToWorldPoint(mousPos);
        realPos.z = 0;
        transform.position = realPos;
    }
    void Shoot()
    {
        _shotTimer -= Time.deltaTime;
        if (Input.GetMouseButtonDown(1))
        {
            if (_shotTimer <= 0)
            {
                GameObject shotParticle = Instantiate(_particlShot, _pointShot.position, Quaternion.identity);
                Destroy(shotParticle, 4f);
                GameObject laserMus = Instantiate(_laserVolume, _pointShot.position, Quaternion.identity);
                Destroy(laserMus, 2f);
                Instantiate(_bulletPrefab, _pointShot.transform.position, Quaternion.identity);
                _shotTimer = _timerShotInterv;
            }
        }
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;
        StartCoroutine(Respawn());
        
    }
    private IEnumerator Respawn()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        _protectionCircle.SetActive(true);
        yield return new WaitForSeconds(2f);
        GetComponent<BoxCollider2D>().enabled = true;
        _protectionCircle.SetActive(false);
    }
}
