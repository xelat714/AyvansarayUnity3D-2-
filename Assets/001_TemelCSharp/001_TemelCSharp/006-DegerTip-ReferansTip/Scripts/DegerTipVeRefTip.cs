using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegerTipVeRefTip : MonoBehaviour
{
    
    void Start()
    {
        //DegerTipler();
        RefTipler();
    }



    // Update is called once per frame
    void Update()
    {
        
    }



    void RefTipler()
    {
        //Ram201
        string[] sinifa = { "Özgür", "Sıraç", "Şeref" };            //"Semih", "Türker", "Mehmet"       202
        //heap kısmında tutulur.

        //otomatikman new liyor mu newlemiyor mu - newliyormuş..

        //Ram202
        string[] sinifb = { "Sadık", "Türker", "Mehmet" };          //"Mert", "Furkan", "Mahmut"       203


        string[] sinifc = { "Mert", "Furkan", "Mahmut" };           //"Mert", "Furkan", "Mahmut"        203

        string[] sinifd = { "Davut", "Samih", "Abdurrezzak" };      


        sinifa = sinifb;
        sinifb = sinifc;
        //sinifb = sinifc;

        sinifb[0] = "Semih";
        //sinifc[1] = "Ali";

        //Debug.Log(sinifa[2]);
        //Debug.Log(sinifc[1]);

        Debug.Log(sinifb[0]);
        Debug.Log(sinifb[1]);
        Debug.Log(sinifb[2]);
        //Debug.Log(sinifa[0]);

    }


    void DegerTipler()
    {

        int _sayi1 = 10;        //Stack alanında int tipinde sayi1 değişkeni oluşturur
        int _sayi2 = _sayi1;    


        _sayi1++;

        _sayi2 = _sayi1;


        Debug.Log("Sayi1 -> " + _sayi1);
        Debug.Log("Sayi2 -> " + _sayi2);

        //Referans tipler null içerebilir fakat değer tipler null olmaz.
    }

}
