using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Rigidbody2D))]//Yazdıgımız scripti atadıgımız objeye otomatik o komponenti ekler ve silmemize izin vermez.
public class OPlayerController : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] UnityEngine.Rigidbody2D _rigidbody;
    bool _isJumpActiveButton;
    MoveComponent _moveComponent;
    [SerializeField] float _fSpeed;

    //[Header("Karakter zıplama ayarı")] [SerializeField] private bool _ziplayabilirMi;
    //[Header("Karakter zıplama kuvveti")] [Range(250, 500)] [SerializeField] private float _ziplamaKuvveti;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJumpActiveButton = true;
        }
    }

    private void Awake()
    {
        _moveComponent = new MoveComponent();
        _rigidbody = GetComponentInChildren<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_isJumpActiveButton)
        {
            _moveComponent.JumpMove(_rigidbody, _fSpeed, true);
        }
        _isJumpActiveButton = false;
    }

}
