using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineOrnek : MonoBehaviour
{
    /*
     Coroutine: Bu metodun en sık kullanım şekli projemizdeki bir kodu belli bir zaman sonra başlatmaktır.
    Coroutineler yazmış oldugumuz bir metodun bitmesini bekleyebilir ve daha sonra beklediği metodun içerisindeki işlemler bittikten sonra 
    diğer metoda geçer. Örneğin trafik lambası ya da serverdan resim çekme. Bunun gibi kullanım senaryoları mevcuttur.
     
     
     
     */

    [SerializeField] UnityEngine.SpriteRenderer _circle1, _circle2, _circle3;
    [SerializeField] Text _info;

    void Kirmizi() 
    {
        _circle1.color = Color.red;
        _info.color = Color.red;
        _info.text = "DUR";
    }
    void Sari() 
    {
        _circle2.color = Color.yellow;
        _info.color = Color.yellow;
        _info.text = "HAZIRLAN";
    }
    
    void Yesil() 
    {
        _circle3.color = Color.green;
        _info.color = Color.green;
        _info.text = "GEÇ";
    }
    private void Start()
    {
        StartCoroutine(TrafikLambalari());
    }

    IEnumerator TrafikLambalari() 
    {
        yield return new WaitForSeconds(2);
        Kirmizi();
        yield return new WaitForSeconds(2);
        _circle1.color = Color.white;
        Sari();
        yield return new WaitForSeconds(2);
        _circle2.color = Color.white;
        Yesil();
    }


}
