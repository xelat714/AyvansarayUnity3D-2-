using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : IMoverR
{

    


    public float Jump => Input.GetAxis("Jump");


    public void JumpMove(Rigidbody2D _rigid, float _forceSpeed, bool _isJumpActive) 
    {

        switch (_isJumpActive)
        {
            case true:

                _rigid.AddForce(Vector2.up * _forceSpeed);
                break;

            default:

                _isJumpActive = false;
                break;
        }

    }





}




