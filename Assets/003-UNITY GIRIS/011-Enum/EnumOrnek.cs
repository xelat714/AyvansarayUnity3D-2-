using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumOrnek : MonoBehaviour
{
    /*
     
     
     ENUM: 
    Bu yapı yazılım dilinde enum, enumaration ya da enum sabitleri olarak adlandırılır. Değişkenlerin alabileceği değerlerin belli(sabit) olduğu durumlarda programı daha okunabilir hale getirmek için
    kullanılır. Programda bir çok değişkene tek tek sayısal değer vermek yerine enum kullanılabilir. özet olarak enum yapısı sayıları anlamlı şekilde isimlendirerek kullanabilmeye izin verir.
     
     
     
     
     
     */

    public enum Yonler
    {
        Sol, Sag, Yukari , Asagi
    }

    public enum Plakalar
    {
        Ankara = 6, İstanbul = 34, İzmir = 35, Osmaniye = 80 //Stringle başlaması lazım
    }

 
}
