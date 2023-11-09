using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnRate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, transform.position, transform.rotation);
            timer = 0;

        }

    }
}
