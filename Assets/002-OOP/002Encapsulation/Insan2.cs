using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insan2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        deneme();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField] string _denemee1, _denemee2;

    void InsanOlustur()
    {

        Insan _insan1 = new Insan();
        _insan1.FirstName = "Emirhan";
        _insan1.LastName = "Kayapinar";
        _insan1.Age = 200;

        Insan _insan2 = new Insan();
        _insan2.FirstName = "Emirhan";
        _insan2.LastName = "Kayapinar";
        _insan2.Age = 150;

        Insan _insan3 = new Insan();
        _insan3.FirstName = "Emirhan";
        _insan3.LastName = "Kayapinar";
        _insan3.Age = 200;

    }

    void deneme() 
    {

        Insan _deneme = new Insan();
        _deneme.Ceyda = _denemee1;
        Insan _deneme2 = new Insan();
        _deneme2.Ceyda = _denemee2;
    
    }


}
