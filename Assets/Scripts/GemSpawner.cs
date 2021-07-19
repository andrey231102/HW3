using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    [SerializeField] private Gem _template;
    [SerializeField] private float _periodOfSpawn;

    private void Start()
    {   
        StartCoroutine(spawn(_template, _periodOfSpawn));
    }

    private IEnumerator spawn(Gem template, float spawnDelayTime)
    {
        var periodOfSpawn = new WaitForSeconds(spawnDelayTime);

        while (true)
        {
            yield return periodOfSpawn;
            var createdGem  = Instantiate(template);
        }
    }
}
