using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMaster : MonoBehaviour
{
    public float life;

    void Start()
    {
        life = 5f; // 5 seconds
    }

    void Update()
    {
        life -= Time.deltaTime;
        if (life < 0)
        {
            Destroy(this.gameObject);
        } // Fruit dies
    }
}
