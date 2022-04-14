using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyScript : MonoBehaviour
{
    /*
     
     Rigidbody bileseni, unity fizik motorunu kullanarak gerçek dünyada oldugu gibi fiziksel hareketlerin taklit edilmesini sağlar.
     Yerçekimi yüzünden nesnelerin aşağı düşmesi, yuvarlak objelerin yuvarlanarak gitmesi, köşeli objelerin sabit kalması gibi hareketleri dusunebiliriz.
     Bu bileşen sayesinde objelere gerçekçi şekilde hareket yeteneği de verebiliriz. Ornegin bir araba modelinde, tekerlere döndürme kuvveti(tork) uygulayarak arabanın ilerlemesini sağlayabilir ve tekerlerin
    rotasyonunu değiştirerek sağa sola hareket ettirebiliriz.


    BODY TYPE:

    Dinamic: Dinamik oyun nesneleri tamamen oyun motoru tarafından etkilenir. Dinamik oyun nesnelerinin hareketi, kuvveti ve hızı gibi faktörlerden etkilenir. 

    Kinematic: Kinematik oyun nesneleri tamamen komut dosyaları tarafından yönlendirilir. Bu nedenle hareket bölümü manuel olarak ele almamız gerekir. Kinematik oyun nesneleri yalnızca dinamik oyun nesneleri ile
    çarpışmaları işler.

    Static: Herhangi bir eylemden etkilenmez. Sabit nesnelere verilebilir. Örnek: zemin, yıkılmayan duvar.
     
    SIMULATED:

    Çalışma süresi boyunca rigidbody2d ve ekli herhangi bir collider2d etkileşimine girmesini istiyorsak kullanırız.

    MASS : Kütle
     
    AUTOMASS : OTOMATİK KÜTLE
     
    LİNEAR DRAG : SÜRTÜNME KATSAYISI 
    
    GRAVITY SCALE: YERÇEKİMİ KUVVETİ

    SLEEPİNG MODE: BEKLEME DURUMUNDAYKEN İŞLEMCİ ZAMANDAN TASARRUF ETMEK İÇİN GAMEOBJECTİN NASIL UYUYACAGINI TANIMLARIZ.

    Never Sleep: uyku devre dışı bırakılır. Runtimeda olmasa bile colliderlar çalışmaya devam eder.(Sistemi yordugu için kaçınırız)
    Start Awake: Gameobject oyun başladıgında çalışır. 
    Start Asleep: gameobject başlangıçta uykudadır. Ancak çarpışmada uyandırılır. 
     
     
     
     */
}
