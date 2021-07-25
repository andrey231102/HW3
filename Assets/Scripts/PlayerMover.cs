using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Vector2 _speed;

    private Rigidbody2D _rigidbody2D;
    private float _direction;

    public float Direction => _direction;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _direction = Input.GetAxis("Horizontal");
        transform.position += new Vector3(_direction, 0, 0) * Time.deltaTime * _speed.x;

        if (Input.GetKeyDown(KeyCode.Space)&& Mathf.Abs(_rigidbody2D.velocity.y)==0)
        {
            _rigidbody2D.AddForce(new Vector2(0, _speed.y), ForceMode2D.Impulse);
        }
    }
}
