﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Gem>(out Gem Gem))
        {
            Collect(collision);
        }
    }

    private void Collect(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
