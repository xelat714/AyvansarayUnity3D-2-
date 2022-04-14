using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsOrnek : MonoBehaviour
{
    /*


     Playerprefs: basit düzeyde veri depolamamızı ve kaydetmemizi sağlayan bir yapıdır. Pp ile oyuncunun yüksek skorunu altın sayısını ya da basit düzeyde dil seçeneklerini tutmak için kullanılır.


     Pp ile int,float ,string gibi değerler tutabiliriz.

     DeletaAll();: kayıtlı tüm veriler ramden silinir.
    DeleteKey("ASDASD") :Belirtilen anahtar ve onunla ilgili herşeyi siler. 

     */
    
    string _ramdeTutulacakBilgi;
    [SerializeField] InputField _input;
    [SerializeField] Text _sonucText;
    public void VeriGonder()
    {
        string _result = _input.text;
        PlayerPrefs.SetString("sadik", _result);

    }
    private void Start()
    {
        _sonucText.text = PlayerPrefs.GetString("sadik");
        // Bu kod yorum satırında bırakılır sürekli : PlayerPrefs.DeleteAll(); /**************************
        //PlayerPrefs.DeleteKey("sadik");
    }

}
