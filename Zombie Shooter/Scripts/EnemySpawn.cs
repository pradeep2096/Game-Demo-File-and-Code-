using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform Enemies;
    public float minx, maxx;
    public float SpawnRate;
    public float minz, maxz;
    float Randx;
    float t;
    float Randz;

    // Start is called before the first frame update
    void Start()
    {

        t = 4f;
        //InvokeRepeating("Spawn", startTime, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        if(t<=0)
        {
            Spawn();
            t = SpawnRate;
            Randx = (Random.Range(minx, maxx));
            Randz = (Random.Range(minz, maxz));
        }
        else
        {
            t -= Time.deltaTime;
        }
        
    }
    void Spawn()
    {
        Instantiate(Enemies, new Vector3(Randx, 0, Randz), Quaternion.identity);
    }
        
        
}
