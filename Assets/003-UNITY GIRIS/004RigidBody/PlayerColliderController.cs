using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliderController : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D _ornek)
    {
        Debug.Log("Çarptı");
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Çarpıyor");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Ayrıldı");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
