using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerScript : MonoBehaviour
{

    /*
     * Input sınıfının metotlarıyla, kullanıcıdan tüm girdileri alabiliriz. Genellikle true, false (bool) döndüğü için çoğunlukla if bloklarını kullanırız.
     
     
     
     
     inputları updatede aldır transform işlemlerini fixed updatede yaptır.
     
     
     keycodelar genelde kullanılmıyor.
      

    fizik olayları fixed updatede inputları fixedda yapılır.
     
     
     
     
     
     
     
     
     */
    void Movement()
    {
        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.position += new Vector3(0.2f, 0);
        }

        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.position -= new Vector3(0.2f, 0);
        }

        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.position -= new Vector3(0, 0.2f);
        }

        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            transform.position += new Vector3(0, 0.2f);
        }
    }

    void Movement2() 
    {
        switch (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            case true:
                transform.position += new Vector3(0.2f, 0);
                break;
        }

        switch (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            case true:
                transform.position -= new Vector3(0.2f, 0);
                break;
        }

        switch (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            case true:
                transform.position -= new Vector3(0, 0.2f);
                break;
        }

        switch (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            case true:
                transform.position += new Vector3(0, 0.2f);
                break;
        }


        


    }
    bool _sagTus;
    bool _solTus;
    bool _yukariTus;
    bool _asagiTus;

    // Update is called once per frame
    void Update()
    {

        //Movement();
        //Movement2();
        if (Input.GetKey("d"))
        {
            _sagTus = true;
        }
        if (Input.GetKey("s"))
        {
            _asagiTus = true;
        }
        if (Input.GetKey("w"))
        {
            _yukariTus = true;
        }
        if (Input.GetKey("a"))
        {
            _solTus = true;
        }

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Sol tusa basıldı");
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    Debug.Log("sağ tusa basıldı");
        //}
        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("scroll tusuna basıldı");
        //}


    }
    //getkey metodu kullanıcının klavye üzerinden belirtilen tuşa basılıp basılmadıgını tespit etmek için kullanılır.
    private void FixedUpdate()
    {
        Movement3();

    }

    void Movement3() 
    
    
    {
        if (_sagTus)
        {
            transform.position += new Vector3(0.5f, 0);
            _sagTus = false;
        }

        if (_solTus)
        {
            transform.position -= new Vector3(0.5f, 0);
            _solTus = false;
        }

        if (_yukariTus)
        {
            transform.position += new Vector3(0, 0.5f);
            _yukariTus = false;
        }

        if (_asagiTus)
        {
            transform.position -= new Vector3(0, 0.5f);
            _asagiTus = false;
        }



    }
    
    /*
     * GetKeyDown metodu: GetKeyde oldugu gibi kullanıcı klavyeden belirlediğimiz tuşa basıldıgı zaman tetiklenmesi için kullanılır. Ancak basılı olsa bile sadece bir kez çalışır.
     * GetKeyUp Metodu: GetKeyDown metodunun tam tersi şeklinde çalışır. Yani kullanıcı belirtilen tuşa basmayı bıraktıgında çalışır.(cs bomba örneği)
     * GetMouseButton metodu mouse üzerinde yer alan tuşlara basılı tutup tutulmadığını kontrol etmek için kullanılan metottur.Mouse üzerinde yer alan tuşları ayrı ayrı kontrol edebiliriz.
     * GetMouseButtonDown:... aynısı
     * GetMouseButtonUp: .... aynısı
     
     //serialize field range yazarak inspectordan aralık verebiliriz.
     
     
     */




}
