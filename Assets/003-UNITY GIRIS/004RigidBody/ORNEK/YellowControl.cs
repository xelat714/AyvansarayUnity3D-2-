using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowControl : MonoBehaviour
{
    [SerializeField] OPlayerControl _pc;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            _pc._vActive = false;
        }
    }
}
