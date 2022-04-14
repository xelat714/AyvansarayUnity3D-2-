using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerr : IMoveControll
{
    public float Emir => Input.GetAxis("Horizontal") * Time.deltaTime;

    public float Vertical => Input.GetAxis("Vertical") * Time.deltaTime;

    public float Jump => Input.GetAxis("Jump");


    public void HorizontalAxis(UnityEngine.Transform _transform,float _hSpeed,bool _isHorizontalActive,UnityEngine.SpriteRenderer _player) 
    {
        switch (_isHorizontalActive)
        {

            case true:
                _transform.position += new Vector3(Emir * _hSpeed, 0);
                if (Input.GetKey(KeyCode.D))
                {
                    _player.flipX = false;
                }
                if (Input.GetKey(KeyCode.A))
                {
                    _player.flipX = true;
                }
                break;  
            default:
                _isHorizontalActive = false;
                break;
        }

    }

    public void VerticalAxis(UnityEngine.Transform _transform, float _vSpeed, bool _isVerticalActive) 
    {

        switch (_isVerticalActive)
        {

            case true:

                _transform.position += new Vector3(0, Vertical * _vSpeed);
                break;


            default:
                _isVerticalActive = false;
                break;
        }

    }

    public void Jumpp(Rigidbody2D _rigid,float _jSpeed,bool _isJumpActive) 
    {

        switch (_isJumpActive)
        {
            case true:

                _rigid.AddForce(Vector2.up * _jSpeed);
                break;
            
            default:
                _isJumpActive = false;
                break;
        }



    }
   






}
