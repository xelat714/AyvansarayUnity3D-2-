using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebalTrigger : MonoBehaviour
{


    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
