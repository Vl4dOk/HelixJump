using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialX : MonoBehaviour
{
    [SerializeField] private Material _dissolveMaterial;
    [SerializeField] private float _dissolveSpeed = 0;
    public bool _isCollision = false;

    private void Start()
    {
        _dissolveMaterial.SetFloat("_Activate", 0);
    }


    private void FixedUpdate()
    {
        if (_isCollision && _dissolveSpeed < 1)
        {            
            _dissolveMaterial.SetFloat("_Activate", _dissolveSpeed += 0.0023f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Segment2 segment2))
        {
            _isCollision = true;
        }
    }
}

