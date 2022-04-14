using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORRRNEK : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DictionaryOlustur();

        //ListeOlustur();
        SilahOlustur();
        
       
    }

    // Update is called once per frame
    void Update()
    {

    }


    //1.Soru
    void DictionaryOlustur()
    {
        Dictionary<int, string> _ornek = new Dictionary<int, string>();
        _ornek.Add(01, "Adana");
        _ornek.Add(34, "İstanbul");
        _ornek.Add(06, "Ankara");
        _ornek.Add(31, "Hatay");
        _ornek.Add(27, "Gaziantep");

        foreach (var item in _ornek)
        {
            Debug.Log(item.Value);
        }

    }

    
    void SilahOlustur() 
    {

        Tabanca _deagle = new Tabanca();
        _deagle.SilahAdi = "Deagle";
        _deagle.Hasar = 500;
        _deagle.HasarHesapla();
        Debug.Log(_deagle.Hasar);
        
       
    
    }
    

    
//dizi olsun params ile n kadar eleman alsın

    // liste olsun 5 itemli starta bastıgında değerler görünsün
    //array olustur eleman sayısı 2 den küçükse ... büyükse ....
    void ListeOlustur() 
    {

        List<int> _deneme = new List<int>();
        _deneme.Add(1);
        _deneme.Add(2);
        _deneme.Add(3);
        _deneme.Add(4);
        _deneme.Add(5);
        for (int i = 0; i < _deneme.Count; i++)
        {
            Debug.Log(_deneme[i]);
        }
    
    
    
    
    }


    //void ArrayDeneme() 
    //{

    //    int[] _ornekk = new int[7];




    //}

    int _paraMiktari;

    void ParaHesapla() 
    {

        _paraMiktari = Random.Range(1, 2000);

        if (_paraMiktari<500)
        {
            Debug.Log("Fakir");
        }

    }

}
    

