using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeGenerator : MonoBehaviour
{
    public GameObject prefab; 
    public float xRange = 5f; 
    public float y = 0.9f; 
    public float zRange = 5f;
    public int num = 10;
    // Start is called before the first frame update
    void Start()
    {
 

        for (int i = 0; i < num; i++)
        {
            float x;
            float z;

            if (Random.value < 0.5f) // 50% chance
            {
                x = Random.Range(-xRange, -1);
            }
            else
            {
                x = Random.Range(xRange, 1);
            }

            if (Random.value < 0.5f) // 50% chance
            {
                z = Random.Range(-zRange, -1);
            }
            else
            {
                z = Random.Range(zRange, 1);
            }

            Vector3 randomPosition = new Vector3(x, y, z);
            Instantiate(prefab, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
