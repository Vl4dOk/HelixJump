using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderGraphContent1 : MonoBehaviour
{ 
    [SerializeField] private Material _dissolveMaterial;
    [SerializeField] private float _dissolveSpeed = 0;
    public bool _isActive = false;

    private void Start()
    {
        _dissolveMaterial = GetComponent<MeshRenderer>().material;
        _dissolveMaterial.SetFloat("_Activate", 0);
    }


    private void FixedUpdate()
    {
        if (_isActive && _dissolveSpeed < 1)
        {
            _dissolveMaterial.SetFloat("_Activate", _dissolveSpeed += 0.0023f);
        }
    }
}

