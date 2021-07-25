using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerMover))]

public class PlayerAnimator : MonoBehaviour
{
    private PlayerMover _direction;
    private Animator _animator;

    private void Start()
    {
        _direction = GetComponent<PlayerMover>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat("Speed", _direction.Direction);
    }
}
