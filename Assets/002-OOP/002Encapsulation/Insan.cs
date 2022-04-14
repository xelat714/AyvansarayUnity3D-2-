using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insan :MonoBehaviour//Insan nesnesi olusturma
{
    //proplarda snakecase ve camelcase kullanılmaz.

    //public string _Adi { get; set; }//get bilgiyi getirmek set set etmek. Set ile başka classtan veri alınabilir.
    //Bilgiyi okumak istediğimizde get çalışır. atamak istediğimizde set. Bu yazım new propertydir.
    //prop tab tab ile gelir.
    //kapsülleyerek girilen veriyiyi kısıtlarız. Boşluk olmasın özel karakter olsun vs.
    //Kapsülleyecegimiz propertyi old propertye dönüştürmeliyiz.

    //En özgün erişilebilir olan sırasıyla: public, internal, protected ve private 

    //New properties
    public string FirstName { get; set; }// dşardan okunup değiştirilmemesi için setin önüne private yazarız.
    public string LastName { get; set; }
    //public int Age { get; set; } // Encapsulation uygulanacak.
    
    //string _firstName;
    //string _lastName;
    int _age;
    //New property oluşturulurken fieldlara ihtiyaç duymayız. Old propertyde kapsülleme için fieldlara ihtiyaç duyarız.
    string _ad;
    public int MyProperty 
    { 
        get 
        {
            return _age;
        } 
        set 
        { 
            
        } 
    }
    public int Age 
    
    {
        get
        {
            return _age;
        }
        set                      //Old prop yöntemi
        {
            if (value < 18 || value > 100)
            {
                Debug.Log("Geçerli bir sayı girin");
            }

            else
            {
                _age = value;
            }
            
        } 
    
    }
    public string Ceyda 
    { 
        get 
        {
            return _ad;
        } 
        
        set 
        {
            if (value.Length < 5)
            {
                Debug.Log($"{value} 5 ten küçük olamaz");
            }
            else
            {
                _ad = value;
                Debug.Log(_ad);
            }
        } 

    }














}
