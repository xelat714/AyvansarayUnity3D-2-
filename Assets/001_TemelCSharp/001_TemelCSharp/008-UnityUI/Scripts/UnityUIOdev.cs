using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityUIOdev : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    [SerializeField] InputField _sayiBirIF, _sayiIkiIF;

    [SerializeField] Text _toplamText;
    [SerializeField] Text _cikarmaText;
    [SerializeField] Text _carpimText;
    int _sayi1, _sayi2, _sonuc;
    [SerializeField] Image _backgroundColor;


    public void RandomSayiBelirle() 
    
    {
        _sayi1 = UnityEngine.Random.Range(1, 1000);
        _sayi2 = UnityEngine.Random.Range(1, 1000);

        _sayiBirIF.text = _sayi1.ToString();
        _sayiIkiIF.text = _sayi2.ToString();

    }

    public void Toplama() 
    {
        
        _sonuc = _sayi1 + _sayi2;

        if (_sonuc < 200)
        {
            _backgroundColor.color = Color.yellow;
        }

        else if (200 < _sonuc && _sonuc < 500)
        {
            _backgroundColor.color = Color.blue;
        }

        else
        {
            _backgroundColor.color = Color.red;
        }

        _toplamText.text = _sonuc.ToString();
    }

    public void Cikarma()
    {
        
        
        _sonuc = _sayi1 - _sayi2;

        if (_sonuc < 200)
        {
            _backgroundColor.color = Color.yellow;
        }

        else if (200 <_sonuc && _sonuc<500)
        {
            _backgroundColor.color = Color.blue;
        }

        else
        {
            _backgroundColor.color = Color.red;
        }

        _cikarmaText.text = _sonuc.ToString();
    }

    public void Carpma()
    {

        _sonuc = _sayi1 * _sayi2;

        if (_sonuc < 200)
        {
            _backgroundColor.color = Color.yellow;
        }

        else if (200 < _sonuc && _sonuc < 500)
        {
            _backgroundColor.color = Color.blue;
        }

        else
        {
            _backgroundColor.color = Color.red;
        }

        _carpimText.text = _sonuc.ToString();

    }






}
