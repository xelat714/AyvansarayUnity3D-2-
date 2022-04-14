using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAraba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArabaOlustur();
    }

    private void ArabaOlustur()
    {
        BmwAksam _bmw1 = new BmwAksam();
        _bmw1.Marka = "BMW";
        _bmw1.Model = "BMW Model";
        _bmw1.SifirMi = true;
        _bmw1.Hizi = 250f;
        _bmw1.KapiSayisi = 2;
        _bmw1.Fiyati = 50000m;

        _bmw1.SatisYap();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
