using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MaviBombaOlustur();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MaviBombaOlustur()
    {
        //1.Yol
        MaviBomba MaviBomba = new MaviBomba();
        MaviBomba.BombaAdi = "Mavi";
        MaviBomba.BombaBuyuklugu = 100;
        MaviBomba.BombaHasar = 500;
        MaviBomba.BombaID = 001;
        MaviBomba.BombaRengi = "Mavi";
        MaviBomba.EkstraHasar = true;

        //2.Yol

        MaviBomba MaviBomba2 = new MaviBomba() { BombaAdi = ("Blue"), BombaID = 002 };

    }


    void KırmızıBolbaOlustur() 
    {


        KirmiziBomba KirmiziBomba = new KirmiziBomba();

        KirmiziBomba.BombaAdi = "Kirmizi";
        KirmiziBomba.BombaBuyuklugu = 200;
        KirmiziBomba.BombaHasar = 1000;
        KirmiziBomba.BombaID = 002;
        KirmiziBomba.BombaRengi = "Kirmizi";








































    
    
    
    
    
    }


}
