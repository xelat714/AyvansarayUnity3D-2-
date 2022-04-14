using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{

    //Transform Komponenti 
    /*
     * Unity hierarşisine eklediğimiz her objenin bir transformu olmalıdır. Transformsuz bir gameobject düşünülemez.
     * Transformlar unity evreninde, objenin; pozisyonunu hangi yöne baktıgınızı ve boyutunu belirlemek için kullanılır.
     * 
     * 
     * Position: Objenin x, y ve z koordinatlarındaki konumudur.
     * Rotation: Objenin x, y ve z eksenleri etrafindaki dönüşü, derece cinsinden ölçülür.
     * Scale: x,y z eksenleri etrafında objenin ölçeği."1 değeri orjinal boyuttur.(nesnenin içe aktarıldıgı boyut)
     * Transformlar referans tiplerdir.
     
     
     
     
     */


    private void Start()
    {
        transform.position = new Vector3(0.2f, 5);
        transform.rotation = new Quaternion(100, 0, 0, 0);
        transform.localScale = new Vector3(1, 1, 1);
    }





}
