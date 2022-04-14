using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabanca : Silahlar
{
    

    public override void HasarHesapla() 
    {

        if (SilahAdi =="Deagle" && Hasar<1000)
        {
            Hasar += 1000;
        }
    
   
    }






}
