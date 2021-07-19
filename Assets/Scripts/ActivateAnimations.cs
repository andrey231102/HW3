using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAnimations : MonoBehaviour
{
    private Movement _direction;
    private Animator _animator;

    void Start()
    {
        _direction = GetComponent<Movement>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _animator.SetFloat("Speed", _direction.Direction);
    }
}
