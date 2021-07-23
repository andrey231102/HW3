using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animator;

    private Transform _target;
    private Transform[] _points;
    private int _currentPoint;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }

        _target = _points[_currentPoint];
    }

    private void Update()
    {
        var direction = (_target.position - transform.position).normalized;

        _animator.SetFloat("Direction", direction.x);

        transform.position = Vector3.MoveTowards(transform.position, _target.position,_speed * Time.deltaTime);

        if (transform.position == _target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
            _target = _points[_currentPoint];
        }

    }
}
