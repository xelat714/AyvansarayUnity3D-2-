using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerr : MonoBehaviour
{
    [SerializeField] float _hSpeed, _vSpeed,_jSpeed;
    [SerializeField] bool _isHorizontalActive, _isVerticalActive,_isJumpActive;
    [SerializeField] UnityEngine.SpriteRenderer _player =new UnityEngine.SpriteRenderer();
    [SerializeField] Rigidbody2D _rigid = new Rigidbody2D();
    MoveControllerr _move;

    private void Awake()
    {
        _move = new MoveControllerr();
    }


    private void FixedUpdate()
    {
        Horizontal();
        Vertical();
    }
    void Horizontal() 
    {
        _move.HorizontalAxis(this.transform, _hSpeed, _isHorizontalActive,_player);
    }
    void Vertical() 
    {
        _move.VerticalAxis(this.transform, _vSpeed, _isVerticalActive);
    }
    void Jump() 
    {
        _move.Jumpp(_rigid, _jSpeed, _isJumpActive);
    
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _isJumpActive = true;
        }
    }
}
