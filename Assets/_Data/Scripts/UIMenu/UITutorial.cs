using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITutorial : MonoBehaviour
{
    protected float time = 0f;
    protected float timeLimid = 2f;

    private void Update()
    {
        this.RemoveUI();
    }
    protected virtual void RemoveUI()
    {
        this.time += Time.deltaTime;
        if (this.time < this.timeLimid) return;
        transform.gameObject.SetActive(false);
    }
}
