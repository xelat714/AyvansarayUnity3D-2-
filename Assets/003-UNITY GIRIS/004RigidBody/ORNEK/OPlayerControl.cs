using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPlayerControl : MonoBehaviour
{

    private OMoveController _OmoveController;

    public float _hSpeed, _vSpeed;
    public bool _hActive, _vActive;

    private void Awake()
    {
        _OmoveController = new OMoveController();
    }
    private void FixedUpdate()
    {
        Horizontal();
        Vertical();
    }
    private void Horizontal() 
    {
        _OmoveController.HorizontalAxis(this.transform, _hSpeed, _hActive);
    }
    private void Vertical() 
    {
        _OmoveController.VerticalAxis(this.transform, _vSpeed, _vActive);
    }
}
