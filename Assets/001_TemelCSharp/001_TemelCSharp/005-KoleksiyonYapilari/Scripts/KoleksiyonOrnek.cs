using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoleksiyonOrnek : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DictionaryOrnek();
        QueueOrnek();
        //ListOrnek();
    }

    // Update is called once per frame
    void Update()
    {

    }



    void ArrayOrnek()
    {
        //1.yol
        int[] _ornekDizi = new int[3];
        _ornekDizi[0] = 10;
        _ornekDizi[1] = 20;
        _ornekDizi[2] = 30;
        // _ornekDizi[3] = 30; hatalı yazımdır. 3 index belirtilmiştir. 

        for (int i = 0; i < _ornekDizi.Length; i++)
        {
            Debug.Log(_ornekDizi[i]);
        }


        foreach (var item in _ornekDizi)
        {
            Debug.Log(item);
        }



        //2.yol
        int[] _ornekDizi2 = new int[3] { 10, 20, 30 };

    }


    void ListOrnek()
    {
        //1.yol
        
        List<string> _listeOrnek = new List<string>();
        _listeOrnek.Add("deger1");
        _listeOrnek.Add("deger2");

        for (int i = 0; i < _listeOrnek.Count; i++)
        {
            Debug.Log(_listeOrnek[i]);
        }

        /*
        //2.yol
        List<string> _listeOrnek2 = new List<string>() { "deger1", "deger2" };


        foreach (var item in _listeOrnek2)  //var olan yere string de yazabilirdik ama birden çok tip değişken olabileceğinden dolayı var olarak bırakıyoruz.
        {
            Debug.Log(item);
        }
        */
    }


    private void DictionaryOrnek()
    {
        //Bir dictionary içerisinde keyler benzersiz olmalıdır.
        //1.yol
        Dictionary<string, string> _dictionaryOrnek = new Dictionary<string, string>();  //istersek string-int / int-string/ int-int de yazılabilir.

        _dictionaryOrnek.Add("Adana", "ADA");
        _dictionaryOrnek.Add("İstanbul", "IST");


        //2.yol
        Dictionary<int, string> _dictionaryOrnek2 = new Dictionary<int, string>() { 
            {1, "Adana" }, 
            {2, "Bursa" }
        
        
        
        };

       

        foreach (var item in _dictionaryOrnek2)
        {
            Debug.Log(item);
        }
    }

    void QueueOrnek()
    {
        //Queue örnek yapısında ilk giren değer ilk çıkar.

        Queue<string> days = new Queue<string>();

        days.Enqueue("Pazartesi");
        days.Enqueue("Salı");
        days.Enqueue("Çarşamba");

        days.Dequeue();
        days.Dequeue();
        
        

        foreach (var item in days)
        {
            Debug.Log(item);
        }


    }

}
