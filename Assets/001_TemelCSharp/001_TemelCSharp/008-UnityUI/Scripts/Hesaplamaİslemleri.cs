using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hesaplamaİslemleri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int _sayi1, _sayi2;

    [SerializeField] InputField _birinciSayiInput, _ikinciSayiInput;
    [SerializeField] Text _sonucText;
    [SerializeField] Image _backgroundColor;

    public void RandomSayiBelirle() 
    {
        _sayi1 = Random.Range(1, 1000);
        _sayi2 = Random.Range(1, 1000);

        _birinciSayiInput.text = (_sayi1).ToString();//1.yöntem
        _ikinciSayiInput.text = (_sayi2).ToString();


        ToplamaİsleminiYap();



    }

    void ToplamaİsleminiYap() 
    {


        int _sonuc = _sayi1 + _sayi2;

        _sonucText.text = $"Toplam = {_sonuc} ";

        if (_sonuc < 1000)
        {
            _backgroundColor.color = Color.red;
        }

        else
        {
            _backgroundColor.color = Color.blue;
        }
    
    
    }






}
