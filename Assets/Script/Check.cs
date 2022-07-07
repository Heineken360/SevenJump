using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour
{
    [SerializeField] private Transform _down;
    [SerializeField] private Transform _target;
    private void Update()
    {
        if (transform.position.y > _target.position.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
