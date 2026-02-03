using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private float _jump;

    public delegate void PointDelegate();
    public event PointDelegate PointEvent;

    public delegate void EndDelegate();
    public event PointDelegate EndEvent;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigidbody.velocity = new Vector2(
                _playerRigidbody.velocity.x,
                _jump
                );
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.tag == "Pipe")
        {
            Destroy(gameObject);
            EndEvent.Invoke();
        }

        if (collider.tag == "Score")
        {
            PointEvent.Invoke();
        }
    }

}
