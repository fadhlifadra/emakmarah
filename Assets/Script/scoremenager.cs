using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremenager : MonoBehaviour
{
    private int score;
    private float timer;
    public Text scoredisplay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            score++;
        }

        scoredisplay.text = score.ToString();
    }
}
