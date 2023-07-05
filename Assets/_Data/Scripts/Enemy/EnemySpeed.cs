using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{

   [SerializeField] protected float speed;
    public float deadZone = -60;
    void Update()
    {
        transform.position = transform.position + (Vector3.left *speed) *Time.deltaTime;
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
