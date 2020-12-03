using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anak : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position=targetPos;
        } else if (Input.GetKeyDown(KeyCode.DownArrow)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position=targetPos;
        }
    }
}
