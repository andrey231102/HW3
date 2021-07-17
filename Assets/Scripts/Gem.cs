using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Gem : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    [SerializeField] private float _xForceValue;
    [SerializeField] private float _yForceValue;

    private void Start()
    {
        Vector2 position = new Vector2(Random.Range(-1 * _xForceValue,_xForceValue), _yForceValue);
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.AddForce(position);
    }
}
