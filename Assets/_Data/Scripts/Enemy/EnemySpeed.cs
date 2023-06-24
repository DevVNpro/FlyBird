using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{

    public float run = 5;
    public float deadZone = -60;
    void Update()
    {
        transform.position = transform.position + (Vector3.left *run) *Time.deltaTime;
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
