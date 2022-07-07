using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        if (transform.position.y < _target.position.y)
        {
            transform.position = new Vector3(transform.position.x, _target.position.y, transform.position.z);
        }
    }
}
