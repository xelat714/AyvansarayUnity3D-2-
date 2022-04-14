using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ornek2: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] _tombala = { 1, 2, 3 };    //   17, 8, 15      202
        int[] _tombala2 = { 4, 5, 6 };   //   10, 16, 12     203
        int[] _tombala3 = { 7, 8, 9 };   //   17, 8, 15      202 
        int[] _tombala4 = { 10, 11, 12 };//   17, 8, 15      202

        _tombala = _tombala3;
        _tombala2 = _tombala4;
        _tombala4 = _tombala;

        _tombala3[2] = 15;
        _tombala2[1] = 16;
        _tombala[0] = 17;

        Debug.Log(_tombala[0]); 
        Debug.Log(_tombala2[0]); 
        Debug.Log(_tombala3[0]);
        Debug.Log(_tombala4[0]);


    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
