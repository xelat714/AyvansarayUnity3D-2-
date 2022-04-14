using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    //[SerializeField] GameObject _a, _b, _c;
    [SerializeField] GameObject _obje;

    [SerializeField] float _hiz;
    private void FixedUpdate()
    {
        //_a.transform.position += new Vector3(Input.GetAxis("Horizontal")*_hiz*Time.deltaTime,0);
        //_b.transform.position += new Vector3(Input.GetAxis("Horizontal")*_hiz*Time.deltaTime,0);
        //_c.transform.position += new Vector3(Input.GetAxis("Horizontal")*_hiz*Time.deltaTime,0);
        _obje.transform.position += new Vector3(Input.GetAxis("Horizontal") * _hiz * Time.deltaTime, Input.GetAxis("Vertical") * _hiz * Time.deltaTime);
    }
}
