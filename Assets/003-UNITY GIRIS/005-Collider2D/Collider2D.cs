using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2D : MonoBehaviour
{
    /*
     
     Collider en temeliyle Unity oyun motoru içerisinde kullandıgımız objelerin (Gameobject) birbirinin içerisinden geçmesini
    önleyen veya birbirinin içinden geçip geçmediğini algilamamizi sağlayan, fizik motoruyla beraber kullandıgımız bir yapıdır.
    Collider bilesenlerini nesneleri bir katılık ,bir cerceve kazandıran bileşen olarak da değerlendirebiliriz.

    Bahsettiğimiz şekilde, objelerin birbirine temasini engellemek için öncelikle belirli bir harekete sahip olmalari gerekiyor.
    Objeleri transform bileşeni ile de hareket ettirebiliriz ancak fizik motoru olarak kullanmadgımız için bu temasları ve birbirinin
    içinden geçmeleri algilayamayız. Bu işlemleri yapmak için hareket ettirmek istediğimiz objelerimizi fizik sistemine dahil etmeli,
    yani bu objelere rigidbody bileşeni eklemeliyiz.

    isTrigger: En önemli özelliklerdem biri isTrigger özelliğidir. Bu özelliği aktif hale getirdiğimiz, true değeri atadıgımız takdirde
    objelerimiz artik içinden geçilebilir halde olacaktır. Aynı zamanda bu birbirinin içinden geçme durumlarından da bizi haberdar 
    edecektir. Temas durumlarına dair fonksiyonlara yazinin devaminda detayli şekilde ulaşabilirsiniz.
     

    OnTriggerEnter : obje başka bir objenin geçmeye başladıgı an çalışan fonksiyondur.

    OnTriggerExit : objenin başka bir objenin içinden geçmeyi bıraktığı, üst üste binme işleminin bittiği an çağırılan, aktif olan
    fonksiyondur.

    OnTriggerStay: Obje bir başka objeyle üstüste bindiği sürece , içinden geçmeye devam ettiği sürece, update gibi sürekli çağırılan fonsiyondur.


    Bu fonksiyonların çalışabilmesi için temas edecek iki objeden en az birinin collider isTrigger degeri True olmalı. Trigger halde olmamaları 
    halinde OnCollision seklindeki fonksiyonları aktif olacak ve çağırılacaktır.

     
     */

  



}
