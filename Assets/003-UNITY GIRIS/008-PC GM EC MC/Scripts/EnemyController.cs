using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    
    [SerializeField] float _treeSpeed;


    private void Awake()
    {
       
    }

    void TreeMove() 
    {

        _rigidbody2D.velocity = Vector2.left * Time.deltaTime * _treeSpeed;
    
    }


    private void FixedUpdate()
    {
        TreeMove();
        
    }

}
