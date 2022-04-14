using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class homecontroller : MonoBehaviour
{
    [SerializeField] Text _info;
    //[SerializeField] UnityEngine.SpriteRenderer _background;
    [SerializeField] Rigidbody2D _car;



    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _info.text = "Güvenli bölgedesin";
            _info.color = Color.green;
            //_background.color = Color.green;
            _car.gravityScale = 1;
        }
    }

    private void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        _info.text = "Güvenli bölgeden çıktın";
        _info.color = Color.red;
    }
}
