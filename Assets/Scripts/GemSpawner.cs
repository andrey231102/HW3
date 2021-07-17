using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    [SerializeField] private Gem _template;
    [SerializeField] private float _periodOfSpawn;

    void Start()
    {   
        StartCoroutine(spawn(_template, _periodOfSpawn));
    }

    private IEnumerator spawn(Gem gem, float time)
    {
        var periodOfSpawn = new WaitForSeconds(time);

        while (true)
        {
            yield return periodOfSpawn;
            var createdGem  = Instantiate(gem);
        }
    }
}
