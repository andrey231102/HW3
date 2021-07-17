using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animator;

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
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        var direction = (target.position - transform.position).normalized;

        _animator.SetFloat("Direction", direction.x);

        transform.position = Vector3.MoveTowards(transform.position, target.position,_speed*Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }

    }
}
