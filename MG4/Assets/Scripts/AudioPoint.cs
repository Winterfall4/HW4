using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    private void Start()
    {
        Locator.Instance.Player.PointEvent += HandlePoint;
    }

    public void HandlePoint()
    {
        _sound.Play();
    }
}
