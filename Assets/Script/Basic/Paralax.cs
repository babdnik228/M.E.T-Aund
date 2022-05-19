using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField]
    private float _speedParalax;
    [SerializeField]
    private float _startX;
    [SerializeField]
    private float _endX;
    private void Update()
    {
        transform.Translate(Vector2.left * _speedParalax * Time.deltaTime);
        if(transform.position.x <= _endX)
        {
            Vector2 pos = new Vector2(_startX, 0);
            transform.position = pos;
        }
    }
}
