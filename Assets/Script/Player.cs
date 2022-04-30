using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Transform _pointShot;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private float _timerShotInterv = 5;
    [SerializeField]
    private float _shotTimer;
    
    public int _health;
    [SerializeField]
    private GameObject _panel;
    private void Update()
    {
        Move();
        Shoot();
        if(_health <= 0)
        {
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
                Instantiate(_bulletPrefab, _pointShot.transform.position, Quaternion.identity);
                _shotTimer = _timerShotInterv;
            }
        }
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
