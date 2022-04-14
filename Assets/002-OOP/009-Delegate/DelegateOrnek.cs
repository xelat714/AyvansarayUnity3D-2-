using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateOrnek : MonoBehaviour
{

    /*
     * Delegate: program içerisinde bir ya da birden fazla metodu gösteren(işaret eden) referans türünden bir nesnedir.
     * Programlarımızda delegate(temsilci) kullanmak istediğimizde öncelikle bu delegatein tanımını yapmalıyız.
     * Delegate tanımları tanımlanırken başına delegate anahtar sözcüğü alır.
     * Delegate tanımları interface yapılarına benzerler.
     
     
     
     
     
     
     
     
     
     
     
     */

    //geriye değer döndürmeyen ve parametre almayan delegate
    public delegate void DelegateeOrnek();


    //geriye değer döndürmeyen ve 2 adet parametre alan delegate

    public delegate void DelegateOrnek2(int _sayi1, int _sayi2);

    void Erdem(int item1, int item2) 
    {
    
    }
    void Erdem2(int item1, int item2)
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        DelegateOrnek2 _do2 = new DelegateOrnek2(Erdem);

        _do2 += Erdem2;//EKLEME İŞLEMİ

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
