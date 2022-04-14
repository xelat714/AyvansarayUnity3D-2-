using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfaRomeo : Araba , IAlman
{
    public bool AlmanMi { get ; set; }

    public void AlmanSatisYap()
    {
        if (AlmanMi)
        {
            ToplamFiyati -= 50000;
        }

            
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public AlfaRomeo()
    {
        //bu metot burada gözükmese bile arka planda vardır. Bu bir yapıcı metotdur.Yapıcı metotlar n kadar yüklenici(overload) alabilir.
    }


    public AlfaRomeo(string _marka, string _model, int _hiz, byte _kapiSayisi)
    {
        Marka = _marka;
        Model = _model;
        Hizi = _hiz;
        KapiSayisi = _kapiSayisi;
    }


}
