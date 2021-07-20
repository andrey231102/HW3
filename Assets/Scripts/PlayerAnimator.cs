using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Movement _direction;
    private Animator _animator;

    private void Start()
    {
        _direction = GetComponent<Movement>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat("Speed", _direction.Direction);
    }
}
