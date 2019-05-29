using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{



    public float spawnRate = 10f;

    public GameObject hexagonPrefab;
    private float nextTimetospawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimetospawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimetospawn  = Time.time + 1f  / spawnRate;

        }
    }
}
