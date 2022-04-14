using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silahlar 
{
    public string SilahAdi { get; set; }
    public int Hasar { get; set; }

    public virtual void HasarHesapla() 
    {
        if (SilahAdi=="Deagle")
        {
            Hasar += 100;
        }
        Debug.Log(SilahAdi);
        Debug.Log(Hasar);
    }


    
}
