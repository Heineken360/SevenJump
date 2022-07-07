using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject[]  platformPrefab;

    void Start()
    {
       
        Vector3 SpawnerPosition = new Vector3();
        for (int i = 0; i<3; i++)
        {
            int ndx = Random.Range(0, platformPrefab.Length);
            GameObject go = Instantiate<GameObject>(platformPrefab[ndx]);
            SpawnerPosition.x = Random.Range(-1f, 1f);
            SpawnerPosition.y = Random.Range(-3f, 3f);
            Instantiate(go, SpawnerPosition, Quaternion.identity);
        }
    }
    
}
