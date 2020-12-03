using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mainmenu : MonoBehaviour
{
    public GameObject keluar;
    public void GantiTujuan(string scene)
    {
        Application.LoadLevel(scene);
    }

    public void Keluar()
    {
        Application.Quit();
    }

    public void Kembali(bool kembali)
    {
        keluar.SetActive(kembali);
    }

    void Start()
    {
        keluar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
