using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruit;

    public float FruitRate = 3f; // 3 seconds
    public float minX, maxX, minY, maxY;

    void Start()
    {
        InvokeRepeating("FruitFall", 0f, FruitRate);
    }

    private void FruitFall()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Instantiate(fruit, new Vector2(x, y), Quaternion.identity);
    }
}
