using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KararYapilari : MonoBehaviour
{
    //if  

    //inspector dan 1.notu ve 2. notu  1+2 / 2
    //eğer sonuç x<45 kalsın
    //45=> x && x<=54 şartlı
    //x==55 && x<=69 geçti
    //x => 70 yıldızlı geçtin

    [SerializeField] int _not1, _not2;
    [SerializeField] string _userName, _userName2;

    void Start()
    {
       // OrtalamaHesaplama();
    }

   /*
    void OrtalamaHesaplama()
    {
        int _sonuc = ((_not1 + _not2) / 2);

        if (_sonuc < 45)
        {
            Debug.LogError("Kaldın!");
        }

        if (_sonuc >= 45 && _sonuc <=54)
        {
            Debug.Log("Şartlı Geçtin!");
        }

        if (_sonuc >= 55 && _sonuc <= 69)
        {
            Debug.Log("Geçtin!");
        }

        if (_sonuc >= 70)
        {
            Debug.Log("Yıldızlı Geçtin!");
        }

    }

    */

    void KarakterHesaplamasi()
    {
        if (_userName == "a" || _userName2 == "a")
        {
            Debug.Log("Username " + _userName + " " + "Username2" + " " + _userName2);
        }

        else if(_userName == "fenerbahçe")
        {
            Debug.Log("Username" + " " + _userName);
        }

        else if (_userName == "galatasaray")
        {
            Debug.Log("Username" + " " + _userName);
        }

        else
        {
            Debug.Log("Bulunamadı");
        }
    }

}


