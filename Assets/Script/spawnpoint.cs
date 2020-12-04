using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject[] obstacle;
    // Start is called before the first frame update
    void Start()
    {
        int random1 = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[random1], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
