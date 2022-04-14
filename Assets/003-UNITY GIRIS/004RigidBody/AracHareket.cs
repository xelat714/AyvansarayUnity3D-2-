using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracHareket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] float _speed; 
    // Update is called once per frame
    void Update()
    {

        //float yatay = Input.GetAxis("Horizontal")*_speed;
        //float dikey = Input.GetAxis("Vertical")*_speed;
        //yatay *= Time.deltaTime;
        //dikey *= Time.deltaTime;
        //transform.position += new Vector3(yatay, dikey);
        ArabaCalıstır();
       

    }

    void ArabaCalıstır() 
    {


        transform.position += new Vector3(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, Input.GetAxis("Vertical") * _speed * Time.deltaTime);

        //Debug.Log(Input.GetAxis("Horizontal"));


    }






}
