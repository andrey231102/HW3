using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Gem : MonoBehaviour
{
    [SerializeField] private Vector2 _forceValue;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
        Vector2 position = new Vector2(Random.Range(-1 * _forceValue.x,_forceValue.x), _forceValue.y);
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.AddForce(position);
    }
}
