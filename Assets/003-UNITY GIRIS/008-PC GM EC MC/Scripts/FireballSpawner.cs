using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{

    [SerializeField] GameObject _fireballObject;

    [SerializeField] UnityEngine.Transform _fireTransform;




    private void FixedUpdate()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_fireballObject, _fireTransform.position, _fireTransform.rotation);
        }
    }
}
