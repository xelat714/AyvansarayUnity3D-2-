using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPlayerController : MonoBehaviour
{

    [SerializeField] float _hSpeed, _vSpeed,_jSpeed;
    [SerializeField] bool _isJump;
    Rigidbody2D _rigidbody2D;
    [SerializeField] GameObject _player;


    public bool IsJumpAction => _rigidbody2D.velocity != Vector2.zero;
   
    private void Awake()
    {
        _rigidbody2D = GetComponentInChildren<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJump = true;
        }
    }


    private void FixedUpdate()
    {
        _player.transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*_hSpeed,0);

        if (_isJump && !IsJumpAction)
        {
            _rigidbody2D.AddForce(Vector2.up * _jSpeed);
        }

        _isJump = false;
    }
}
