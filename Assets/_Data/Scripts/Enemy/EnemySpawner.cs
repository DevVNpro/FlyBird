using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Top_Box;
    private float time = 0;
    private float timeLimid = 1.4f;
    public float hightOffset = 7;

    void Update()
    {
        this.TimeSpawn();
      
    }
    protected virtual void TimeSpawn()
    {
        time += Time.deltaTime;
        if (time < timeLimid) return;
        SpawnPipe();
        time = 0;
    }

    protected virtual void SpawnPipe()
    {
        float LowestPoint = transform.position.y - hightOffset ;
        float HightPoint =  transform.position.y+ hightOffset ;
        Instantiate(Top_Box, new Vector3(transform.position.x,Random.Range(LowestPoint,HightPoint),transform.position.z), transform.rotation);
    }



}
