using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnTransform;
    [SerializeField] private GameObject _pipePrefab;
    private float timer = 0.0f;
    private float maxTime = 2f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > maxTime)
        {
            Instantiate(_pipePrefab, new Vector3 (4.61f, Random.Range(-2.5f,3.7f), 0f), _spawnTransform.rotation);
            timer = timer - maxTime;
            //Debug.Log(_spawnTransform.position);
        }

    }
}
