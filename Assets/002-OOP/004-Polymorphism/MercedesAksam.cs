using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercedesAksam : Araba
{
    public bool YuzuyorMu { get; set; }



    public override void SatisYap() //virtual ekleyerek polymorphizme geçiş-sanal method-yani ezilebilir. Bir metodu virtual yapıyorsak bunu override (ezmen) gerekir.

        //AMAÇ ÇAĞIRILAN METODU TEKE İNDİRMEK
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 117000m;
        }

        if (YuzuyorMu)
        {
            ToplamFiyati += 500000m;
        }
    }
}
