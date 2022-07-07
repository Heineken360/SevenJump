using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] platformPrefab;
    
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Check")
        {
            Destroy(gameObject);
            Vector3 SpawnerPosition = new Vector3();
            for (int i = 0; i < 1; i++)
            {
                int ndx = Random.Range(0, platformPrefab.Length);
                GameObject go = Instantiate<GameObject>(platformPrefab[ndx]);
                SpawnerPosition.x = Random.Range(-1f, 1f);
                SpawnerPosition.y = Random.Range(transform.position.y + 2f, transform.position.y + 15f);
                Instantiate(go, SpawnerPosition, Quaternion.identity);
            }
            
        }
    }
}
