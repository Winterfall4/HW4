using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private int _speed;
    void Update()
    {
        transform.Translate(-Vector3.right * _speed * Time.deltaTime);
    }
}
