using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(WaypointMovement))]

public class EnemyAnimator : MonoBehaviour
{
    private WaypointMovement _direction;
    private Animator _animator;

    private void Start()
    {
        _direction = GetComponent<WaypointMovement>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _animator.SetFloat("Direction", _direction.Direction.x);
    }
}
