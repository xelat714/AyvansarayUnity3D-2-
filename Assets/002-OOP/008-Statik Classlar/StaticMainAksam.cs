using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMainAksam : MonoBehaviour
{


    Itemler _itemler = new Itemler() { Adi = "Item1", ID = 1, ItemFiyatı = 10m };



   // StaticItemler _staticItemler = new StaticItemler();  statik classlar newlenemez.
   //static class üyelerine erişmek için newleme işlemine gerek yoktur, doğrudan çağırılırlar.








    // Start is called before the first frame update
    void Start()
    {
        StaticItemler.ID = 200;
        StaticItemler._itemAdi = "KDP";
        StaticItemler._itemFiyati = 10m;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
