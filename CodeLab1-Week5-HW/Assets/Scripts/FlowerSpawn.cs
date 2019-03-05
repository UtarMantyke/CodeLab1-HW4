using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawn : MonoBehaviour
{
    public GameObject flowerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",3,2);
    }
    
    void Spawn()
    {
        GameObject newFlower = Instantiate(flowerPrefab);
        newFlower.transform.position = new Vector2(Random.Range(-8,8),-1.65f);
    }
}
