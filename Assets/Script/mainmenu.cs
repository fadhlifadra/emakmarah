using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mainmenu : MonoBehaviour
{
    public string arah;

    public void GantiTujuan()
    {
    Application.LoadLevel(arah);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
