using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErisimBelirleyicilerOrnek : MonoBehaviour
{
    /*
     
    ***private***

    * Gizli olmasını istediğimiz değerleri tanımlamak için kullandığımız erişim belirleyicisidir.
     *Sadece kendi sınıfından(class) erişilebilir olmasını sağlar.
 
     * Yazdığımız kodda kesinlikle değiştirilmemesi gereken yerler var ise oralarda private kullanırız. Örneğin, karakter canı, silah mermisi, para miktarı..

    
    
      
     ***public***
     
     * public olarak belirlediğiniz değişkenlere her class dan ulaşabiliriz ve değişiklikler uygulayabiliriz. Yani herhangi bir kısıtlama bulunmaz.
     
     
     
     
    
     ***protected***
    
     * Atadığımız değeri korumalı bir hale getirir. 
     * Sadece kendi sınıfından türetilen sınıflar aracılığıyla ulaşılabilir.
    
    
      ***internal***
      
      *Aynı proje içerisinden değiştirilebilir. 
      
      
      
      ***protectedinternal***
      
      *protectedinternal olarak tanımlanmış değer, tanımlandığı sınıfın içinden ve ondan türetilen sınıfların içinden erişilebilir durumdadır. 
      *Türetilen sınıfın aynı program içinden olmaması sorun teşkil etmez. 
      

     */



    //[SerializeField] int a;
    //[HideInInspector] //public i gizliyor. 
    //public string _kullaniciAdi;

    [SerializeField] int _paraMiktari;
    [SerializeField] string _maddiDurumInfo;
    [SerializeField] string _ay;
    [SerializeField] int _minDeger, _maxDeger;



    void Start()
    {
        //MaddiDurumHesaplaIFElse();
        MaddiDurumHesaplaSwitchCase();
    }


    private void MaddiDurumHesaplaIFElse()
    {
        _paraMiktari = Random.Range(_minDeger, _maxDeger);

        if (_paraMiktari <= 500)
        {

            _maddiDurumInfo = "Fakir";

            Debug.Log(_maddiDurumInfo);

        }
        else
        {
            _maddiDurumInfo = "Zengin";

            Debug.Log(_maddiDurumInfo);
        }
    }

    void MaddiDurumHesaplaSwitchCase()
    {

        switch (_ay)
        {
            case "Ocak":
                Debug.Log("Ocak");
                break;

            case "Şubat":
                Debug.Log("Şubat");
                break;

            default:
                Debug.Log("Hiçbiri Değil");
                break;
        }



        _paraMiktari = Random.Range(_minDeger, _maxDeger);

        switch (_paraMiktari <500)
        {
            case true:
                Debug.Log("Fakir");
                break;

            case false:     //default da diyebilirdim. 
                Debug.Log("Zengin");
                break;

            
        }
    }


}
