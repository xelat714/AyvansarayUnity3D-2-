using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMoverComponent : MonoBehaviour
{

    [SerializeField] DirectionEnums _directionEnums;
    [SerializeField] float _dusmanHareketHizi;

    Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = DirectionSelect() * Time.deltaTime * _dusmanHareketHizi;
    }

    Vector2 DirectionSelect()
    {
        Vector2 _directionVector2;
        if (_directionEnums==DirectionEnums.left)
        {
            _directionVector2 = Vector2.left;
        }

        else
        {
            _directionVector2 = Vector2.right;
        }

        return _directionVector2;
    }
}
