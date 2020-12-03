using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anak : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement, speed, maxheight, minHeight;

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed* Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow)&& transform.position.y<maxheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)&& transform.position.y>minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }
    }
}
