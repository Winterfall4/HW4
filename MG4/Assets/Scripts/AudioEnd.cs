using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEnd : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    private void Start()
    {
        Locator.Instance.Player.EndEvent += HandleEnd;
    }

    public void HandleEnd()
    {
        _sound.Play();
        Application.Quit();
    }
}
