using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMove : MonoBehaviour
{

    void Fireball()
    {

        _fireballRigid.velocity = Vector2.right  * _fireballSpeed * Time.deltaTime;

    }
    
    [SerializeField] Rigidbody2D _fireballRigid;
    [SerializeField] float _fireballSpeed;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Fireball();
    }


    
}
