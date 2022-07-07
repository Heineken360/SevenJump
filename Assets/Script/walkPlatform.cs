using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkPlatform : MonoBehaviour
{
    [SerializeField] public  Transform _LeftPoint;
    [SerializeField] private Transform _RightPoint;
    [SerializeField] private Transform _Platform;
    Rigidbody2D rb;
    public float speed;
    public float direction;
    private void Update()
    {
        if((_LeftPoint.position.x > _Platform.position.x ) || (_Platform.position.x > _RightPoint.position.x))
        {
            direction = -direction;
        }
        rb.velocity = new Vector2(speed * direction, rb.velocity.y);
    }
    void Start()
    {
        direction = 1f;
        speed = 2f;
        rb = GetComponent<Rigidbody2D>();
    }
}
