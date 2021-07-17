using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collect(collision,collision.gameObject.TryGetComponent<Gem>(out Gem Gem));
    }

    private void Collect(Collider2D collision, bool isCollectable)
    {
        if (isCollectable)
        {
            Destroy(collision.gameObject);
        }
    }
}
