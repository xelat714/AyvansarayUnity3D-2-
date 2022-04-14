using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{




    string _kullaniciAdi;
    string _email;


    // Start is called before the first frame update
    void Start()
    {
        //int yeniSayi = Method2();
        //Method4(10, 20);

        //int _mehmet = Method4(20, 20);
        //Debug.Log(yeniSayi);


        Method5(4,5,6,7,8,9,1,2,3,4,5,6,7,8,9,1,1,2,3); //istediğim kadar girebilirim. params sayesinde


    }

    // Update is called once per frame
    

    

    #region Geriye değer döndürmeyen ve parametre almayan method
    void Method()
    {
        int sayi1 = 30;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;

        //interpolition
        Debug.Log($"Sonuc {sonuc}");
        Debug.Log("Sonuç " + sonuc);




        Debug.Log("Kullanıcı Adı:" + " " + _kullaniciAdi + " " + "Email:" + " " + _email);
        Debug.Log($"Kullanıcı Adı: {_kullaniciAdi} Email: {_email}");


    }
    #endregion



    #region Geriye int tipinde değer döndüren ve parametre almayan Method


    int Method2()
    {
        int sayi1 = 10;
        int sayi2 = 20;


        int sonuc = sayi1 + sayi2;

        return sonuc;
    }


    #endregion



    #region Geriye değer döndürmeyen ve int tipinde 2 parametre alan Method.


    void Topla(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        Debug.Log($"Toplam:{sonuc}");
    }

    void Topla(int sayi1,int sayi2, int sayi3)
    {
        int sonuc = sayi1 + sayi2 + sayi3;
        Debug.Log($"Toplam:{sonuc}");
    }


    #endregion

    #region Geriye değer döndüren ve int tipinde 2 parametre alan Methodlar.

    int Method4(int _sayi1, int _sayi2)
    {
        int sonuc = _sayi1 + _sayi2;

        Debug.Log(sonuc);
        return sonuc;


    }
    #endregion


    //params keywords
    void Method5(params int[] _sayilar)  //params kullanarak n kadar parametre alabiliriz.
    {
        //int sonuc = 0;

        foreach (var item in _sayilar)
        {
            //sonuc++;
            Debug.Log(item);
        }
    }
}
