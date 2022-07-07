using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;

    [Header("Components")]
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private bool _lookRight;

    private void Update()
    {
        Move();

    }
    private void Move()
    {
        _rigidbody.velocity = new Vector2(Input.acceleration.x * _moveSpeed, _rigidbody.velocity.y);
        //if (Input.GetKey(KeyCode.A))
        //{
         //   _rigidbody.velocity = new Vector2(- _moveSpeed, _rigidbody.velocity.y);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
       //     _rigidbody.velocity = new Vector2(_moveSpeed, _rigidbody.velocity.y);
        //}
        CheckFlip();
    }
    

    private void CheckFlip()
    {
        if (Input.acceleration.x > 0 && !_lookRight)
        {
            Flip();
        } else if (Input.acceleration.x < 0 && _lookRight)
        {
            Flip();
        }
    }
    private void Flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        _lookRight = !_lookRight;
    }

    
    }
