using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hesaplama : MonoBehaviour
{

    [SerializeField] InputField _sayi1IF, _sayi2IF;

    [SerializeField] Text ToplamaText;
    [SerializeField] Text CikarmaText;
    [SerializeField] Text CarpmaText;

    int Topla(int _sayi1, int _sayi2)
    {
        int sonucToplam = _sayi1 + _sayi2;
        return sonucToplam;
    }


    int Cikar(int _sayi1, int _sayi2)
    {
        int sonucToplam = _sayi1 - _sayi2;
        return sonucToplam;
    }


    int Carp(int _sayi1, int _sayi2)
    {
        int sonucToplam = _sayi1 * _sayi2;
        return sonucToplam;
    }




    public void Hesapla()
    {
        int sayi1 = Convert.ToInt32(_sayi1IF.text);
        int sayi2 = Convert.ToInt32(_sayi2IF.text);

        ToplamaText.text =Convert.ToString(Topla(sayi1, sayi2));
        CikarmaText.text = Convert.ToString(Cikar(sayi1, sayi2));
        CarpmaText.text = Convert.ToString(Carp(sayi1, sayi2));

    }


}
