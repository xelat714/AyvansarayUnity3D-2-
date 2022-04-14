using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemler 
{
    /* Statikler: Statik olan bir class ya da yapı her zaman tekildir. Yani bir kere oluşturulurlar ve program çalışıncaya kadar ömürlerini devam ettirirler.
     * Genelde statik classlardan kaçınırız. Bunun nedeni ise , bir statik class oldugunda içindeki her şey static olmalıdır. 
     * class static oldugunda herşey static olmalı. Ama class normal iken diğerleri static olsa da sorun olmaz.
     * 
     
     
     
     
     
     
     
     
     
     
     */



    static int _staticField;//normal classlar static field içerebilir.



    public int ID { get; set; }
    public string Adi { get; set; }
    public decimal ItemFiyatı { get; set; }
    public static int _staticProp { get; set; }

    void NormalMetot()
    {

    }

    static void StaticMetot() 
    { 
    
    }
}
