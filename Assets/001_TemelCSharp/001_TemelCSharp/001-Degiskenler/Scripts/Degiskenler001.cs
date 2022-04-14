using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degiskenler001 : MonoBehaviour
{
    //class altına yazılan her şey global değişkendir.
    //Degiskenler: 

    [SerializeField] private int sayi1 = 10; // public global bir değişkendir
    [SerializeField] float _sayi2 = 20.5f;   //
    [SerializeField] string _kelime = "Merhaba Dünya";
    [SerializeField] bool _aktifMi = false;
    [SerializeField] decimal _Sayi2 = 5454454.454M; //başında bir şey yok ise private değişkendir. 
    [SerializeField] object mehmet = true;


    /* Degisken belirleme kuralları
     
    * Değişken isimleri benzersiz olmalıdır. Büyük küçük harf duyarlıdır ve sayi ile başlayamaz.
    
    * Değişkenler belirlenirken "camelCase" ve "_snakeCase" yöntemi kullanılır.  
     
    * Private bir değişken kullanılırken "snakeCase" yöntemi kullanılır.
    
    * Değişkene deklere ettikten sonra ";" kullanırız.
    * 
    * 



    */

    private void Awake()    
    {
        Debug.LogError("Awake Çalıştı.");

        Debug.LogWarning("Awake Çalıştı.");
        //ilk çalışan, şahsi methodları çalıştıran methoddur. 
        //sadece 1 kez çalışır ve durur.
    }

    private void Start()
    {
        //Debug.Log("Start Çalıştı.");
        //Awake den sonra çalışan methoddur.
        //Sadece 1 kez çalışır ve durur.
    }


    private void Update()
    {
        //Debug.Log("Update Çalıştı.");
        //Bir kere çalışır ve durmaz. 
        //Update frame bazlı çalışır. Eğer bilgisayarınız 60frame ise saniyede 60kez çalışır. Eğer frame 120 ise saniyede 120kez çalışır. 
        //Çalışma aralıkları farklılık gösterir. 
    }

    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate Çalıştı.");
        //Düzenli bir şekilde belirli aralıklarda çalışır (update gibi). Default değeri : 0,02 saniyede çalışır.  
    }

    private void LateUpdate()
    {
        //Debug.Log("LateUpdate Çalıştı.");
        //Update ve FixedUpdate bittikten sonra sürekli çalışır. 
    }
}
