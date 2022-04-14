using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ornek : MonoBehaviour
{


    [SerializeField] string _gun;
    [SerializeField] int _sayi;






    // Start is called before the first frame update
    void Start()
    {
        Deneme();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Deneme()
    {
        string[] _haftaningunleri = new string[7];
        _haftaningunleri[0] = "Pazartesi";
        _haftaningunleri[1] = "Salı";
        _haftaningunleri[2] = "Çarşamba";
        _haftaningunleri[3] = "Perşembe";
        _haftaningunleri[4] = "Cuma";
        _haftaningunleri[5] = "Cumartesi";
        _haftaningunleri[6] = "Pazar";

        

        
                for (int i = 0; i < _haftaningunleri.Length; i++)
                {
                   if( _sayi == i)
                    {

                        Debug.Log(_haftaningunleri[i-1]);
                    }
                }

        


    }


}
